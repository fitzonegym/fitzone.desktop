using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitzone.Controller
{
    public class MembresiaController : IControllersClasesPrincipales<Membresia>
    {
        Contexto contexto = new Contexto();
        public MembresiaController() { }

        public bool Anular(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Membresia>? GetAll()
        {
            return contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")
                .Include("TipoMembresia")
                .OrderByDescending(c => c.fechaAlta).ToList();
        }

        public List<Membresia>? GetActivasXInstructorXActividad(int idInstructor, int idActividad)
        {
            return contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")
                .Include("TipoMembresia")
                .Where(c=>c.idEstadoMembresia == (int)EstadoMembresiaEnum.Activa && c.idInstructor == idInstructor && c.idActividad == idActividad)
                .OrderByDescending(c => c.fechaAlta).ToList();
        }

        public List<Membresia>? GetByIdSocioFecha(int idSocio, DateTime fecha)
        {
            //devuelvo membresias en la fecha pero en cualquier estado
            return contexto.Membresia.Where(m=> m.idSocio == idSocio 
                        && fecha >= m.fechaDesde.AddMinutes(-Statics.MinutosTolerancia) 
                        && fecha <= m.fechaHasta.AddMinutes(-Statics.MinutosTolerancia)).ToList();
        }

        public List<Membresia>? GetByIdSocioFechaActivas(int idSocio, DateTime fecha)
        {
            //devuelvo membresias en la fecha pero en cualquier estado
            return contexto.Membresia.Where(m => m.idSocio == idSocio && fecha >= m.fechaDesde && fecha <= m.fechaHasta && m.idEstadoMembresia == 1).ToList();
        }

        public List<Membresia>? GetByIdSocioFechaTipoMembresia(int idSocio, DateTime fecha)
        {
            //devuelvo membresias en la fecha pero en cualquier estado
            return contexto.Membresia.Include("TipoMembresia").Where(m => m.idSocio == idSocio && fecha >= m.fechaDesde && fecha <= m.fechaHasta).ToList();
        }
        public List<Membresia>? GetAllFilters(Membresia filtro)
        {

            if (filtro.Socio == null)
            {
                filtro.Socio = new Socio();
                filtro.Socio.nombre = "";
                filtro.Socio.idSocio = 0;
            }

            var membresias = contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")
                .Where(c => (filtro.idSocio == 0 || c.idSocio == filtro.idSocio))
                .Where(c => (c.Socio != null && (c.Socio.numeroDocumento + c.Socio.nombre??"".ToUpper() + c.Socio.apellido??"".ToUpper()).Contains(filtro.Socio.nombre??"")))
                .Where(c => c.fechaAlta >= filtro.fechaDesde && c.fechaAlta <= filtro.fechaHasta)                
                .OrderByDescending(c => c.fechaAlta)
                .ToList();

            foreach (var item in membresias)
            {
                item.TipoMembresia = contexto.TipoMembresia.FirstOrDefault(c=>c.idTipoMembresia == item.idTipoMembresia);
            }
            //.Where(c => c.Socio == null ? true : (c.Socio.nombre + c.Socio.apellido).ToUpper().Contains(nombre))
            // .Where(c => c.idSocio == membresia.idSocio || membresia.idSocio == 0)            

            return membresias;
        }

        public Membresia? GetById(int id)
        {
            return contexto.Membresia
              .Include("Socio")
              .Include("Cuotas")
              .FirstOrDefault(c=>c.idMembresia == id);
              
        }

        public Membresia? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Membresia entidad)
        {
            entidad.idMembresia = 0;
            try
            {
              
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Membresia entidad, int id)
        {
            throw new NotImplementedException();
        }

        public int? GetDisponibilidad(TipoMembresia tipo) {
            //obtengo el cupo del tipo de membresia
            int? cupo = contexto.TipoMembresia.FirstOrDefault(t => t.idTipoMembresia == tipo.idTipoMembresia).cupoClase;
            //cuento las membresias existentes con esa actividad

            if (cupo == null)
                return null;

            int cant = contexto.Membresia.Count(m => m.idActividad == tipo.idActividad && m.idEstadoMembresia == (int)EstadoMembresiaEnum.Activa);

            return cupo - cant;
        }

        public void ProcesarEstadoMembresiasFinalizadas(DateTime hoy)
        {
            // marco las nuevas finalizadas 
            // 
            var finalizadas = contexto.Membresia
                          .Where(m => m.fechaHasta < hoy && (m.idEstadoMembresia == (int)EstadoMembresiaEnum.Activa || m.idEstadoMembresia == (int)EstadoMembresiaEnum.Vencida))
                          .ToList();

            if (finalizadas.Count == 0)
                return;

            foreach (var item in finalizadas)
            {
                ////verifico si estan todas las cuotas pagadas
                //if (contexto.Cuota.FirstOrDefault(c=>c.idMembresia == item.idMembresia && !c.pagada) == null)
                //{
                //    //var m = contexto.Membresia.FirstOrDefault(i=>i.idMembresia == item.idMembresia);
                //    item.idEstadoMembresia = (int)EstadoMembresiaEnum.Finalizada;
                //    guardar = true;
                //}
                item.idEstadoMembresia = (int)EstadoMembresiaEnum.Finalizada;
                
            }
            
            contexto.SaveChanges();
        }

        public void ProcesarEstadoMembresiasVencidas(DateTime hoy)
        {
            // tiene una cuota vencida
            // 
            var activas = contexto.Membresia
                          .Where(m => m.idEstadoMembresia == (int)EstadoMembresiaEnum.Activa || m.idEstadoMembresia == (int)EstadoMembresiaEnum.Vencida)
                          .ToList();

            bool guardar = false;

            if (activas.Count == 0)
                return;

            foreach (var item in activas)
            {
                //verifico si tiene alguna cuotas NO pagada segun la fecha
                var c = contexto.Cuota.FirstOrDefault(c => c.idMembresia == item.idMembresia && !c.pagada && c.fechaVencimiento < hoy);
                if (c != null)
                {
                    //var m = contexto.Membresia.FirstOrDefault(i => i.idMembresia == item.idMembresia);
                    item.idEstadoMembresia = (int)EstadoMembresiaEnum.Vencida;
                    guardar = true;
                    var socio = contexto.Socio.FirstOrDefault(s => s.idSocio == item.idSocio);
                    if (socio != null)
                        socio.deudor = true;
                }
                else
                {
                    item.idEstadoMembresia = (int)EstadoMembresiaEnum.Activa;
                    guardar = true;
                }

            }
            if (guardar)
                contexto.SaveChanges();
        }

        public void ProcesarEstadoMembresiasDeshabilitada(DateTime hoy)
        {
            // tiene 2 o mas cuotas vencidas
            // 
            var vencidas = contexto.Membresia
                          .Where(m => m.idEstadoMembresia == (int)EstadoMembresiaEnum.Vencida)
                          .ToList();
            bool guardar = false;

            foreach (var item in vencidas)
            {
                //verifico si tiene alguna cuotas NO pagada segun la fecha
                if (contexto.Cuota.Where(c => c.idMembresia == item.idMembresia && !c.pagada && c.fechaVencimiento < hoy).ToList().Count >= 2)
                {                    
                    item.idEstadoMembresia = (int)EstadoMembresiaEnum.Deshabilitada;
                    guardar = true;
                }
            }

            if (guardar)
                contexto.SaveChanges();

        }

        /// <summary>
        /// actualiza el estado de todas las membresias
        /// </summary>
        public void ProcesarEstadoMembresias(DateTime hoy)
        {
            MembresiaController con = new MembresiaController();
            con.ProcesarEstadoMembresiasFinalizadas(hoy);
            con.ProcesarEstadoMembresiasVencidas(hoy);
            con.ProcesarEstadoMembresiasDeshabilitada(hoy);

        }

    }
}
