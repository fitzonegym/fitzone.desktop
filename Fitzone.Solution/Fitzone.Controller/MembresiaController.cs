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

        public List<Membresia>? GetByIdSocioFecha(int idSocio, DateTime fecha)
        {
            //devuelvo membresias en la fecha pero en cualquier estado
            return contexto.Membresia.Where(m=> m.idSocio == idSocio && fecha >= m.fechaDesde && fecha <= m.fechaHasta).ToList();
        }

        public List<Membresia>? GetByIdSocioFechaTipoMembresia(int idSocio, DateTime fecha)
        {
            //devuelvo membresias en la fecha pero en cualquier estado
            return contexto.Membresia.Include("TipoMembresia").Where(m => m.idSocio == idSocio && fecha >= m.fechaDesde && fecha <= m.fechaHasta).ToList();
        }
        public List<Membresia>? GetAll(Membresia membresia)
        {

            string? nombre = membresia.SocioNombre.ToUpper().Trim();

            var membresias = contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")                
                .Where(c => (c.Socio != null && (c.Socio.nombre.Trim()+ c.Socio.apellido.Trim()).ToUpper().Contains(nombre)))
                .Where(c => c.fechaAlta >= membresia.fechaDesde && c.fechaAlta <= membresia.fechaHasta)                
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

            int cant = contexto.Membresia.Count(m => m.idActividad == tipo.idActividad && m.idEstadoMembresia == 1);

            return cupo - cant;
        }

    

    }
}
