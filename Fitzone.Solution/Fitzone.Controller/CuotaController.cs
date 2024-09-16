using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public class CuotaController : IControllersClasesPrincipales<Cuota>
    {
        Contexto contexto = new Contexto();
        public bool Anular(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cuota>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Cuota? GetAllByIdMembresiaFechaPagada(int idMembresia, DateTime fecha)
        {
            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotaValida = contexto.Cuota
               .FirstOrDefault(i => i.idMembresia == idMembresia &&
                    (fecha >= i.fechaDesde && fecha <= i.fechaHasta && i.pagada)
                    ||
                    (fecha >= i.fechaDesde && fecha <= i.fechaVencimiento)
                    );
               

            //aca hay un problema.
            //si tiene cuotas vencidas de antes y no pagadas

            return cuotaValida;
        }
        public Cuota? GetAllByIdMembresiaFechaNoPagada(int idMembresia, DateTime fecha)
        {
            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotaValida = contexto.Cuota
               .FirstOrDefault(i => i.idMembresia == idMembresia &&
                    (fecha >= i.fechaDesde && fecha <= i.fechaHasta && !i.pagada)
                    ||
                    (fecha >= i.fechaDesde && fecha <= i.fechaVencimiento)
                    );


            //aca hay un problema.
            //si tiene cuotas vencidas de antes y no pagadas

            return cuotaValida;
        }

        //public Cuota? GetAllByIdMembresiaFechaVencimiento(int idMembresia, DateTime fecha)
        //{
        //    //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
        //    var cuotaValida = contexto.Cuota
        //       .FirstOrDefault(i => i.idMembresia == idMembresia &&
        //            (fecha >= i.fechaDesde && fecha <= i.fechaHasta)
        //            ||
        //            (fecha >= i.fechaDesde && fecha <= i.fechaVencimiento)
        //            );


        //    //aca hay un problema.
        //    //si tiene cuotas vencidas de antes y no pagadas

        //    return cuotaValida;
        //}

        public Cuota? GetAllByIdMembresiaFecha(int idMembresia, DateTime fecha)
        {
            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotaValida = contexto.Cuota
               .FirstOrDefault(i => i.idMembresia == idMembresia &&
                    (fecha >= i.fechaDesde && fecha <= i.fechaHasta)                    
                    );
            //aca hay un problema.
            //si tiene cuotas vencidas de antes y no pagadas

            return cuotaValida;
        }

        public Cuota? GetProxima(int idMembresia, DateTime fechaDesde)
        {
            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotas = contexto.Cuota.Where(i => i.idMembresia == idMembresia &&
                    ( i.fechaDesde >= fechaDesde)
                    ).OrderBy(c=>c.fechaDesde).ToList();
            if (cuotas.Count >= 2)
            {
                return cuotas[1];
            }

            return cuotas[0];
        }

        public Cuota? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Cuota? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Cuota entidad)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cuota entidad, int id)
        {
            throw new NotImplementedException();
        }

        public bool Pagar(int idCuota)
        {
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.Cuota.FirstOrDefault(i => i.idCuota == idCuota);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.pagada = true;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cuota> GetCuotasPendientesDePagoTodas(int idMembresia, DateTime fecha)
        {

            var membresia = contexto.Membresia.FirstOrDefault(m => m.idMembresia == idMembresia && m.idEstadoMembresia == 1);

            if (membresia == null)
                return new List<Cuota>();



            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotas = contexto.Cuota
               .Where(i => i.idMembresia == idMembresia && !i.pagada
                    //  (fecha >= i.fechaDesde && fecha <= i.fechaHasta && !i.pagada)
                    ).ToList();            

            return cuotas;
        }

        public List<Cuota> GetCuotasTodas(int idMembresia, DateTime fecha)
        {

            var membresia = contexto.Membresia.FirstOrDefault(m => m.idMembresia == idMembresia );

            if (membresia == null)
                return new List<Cuota>();



            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotas = contexto.Cuota
               .Where(i => i.idMembresia == idMembresia 
                    //  (fecha >= i.fechaDesde && fecha <= i.fechaHasta && !i.pagada)
                    ).ToList();

            return cuotas;
        }

        public List<Cuota> GetCuotasPendientesDePagoAlDia(int idMembresia, DateTime fecha)
        {

            var membresia = contexto.Membresia.FirstOrDefault(m => m.idMembresia == idMembresia && m.idEstadoMembresia == 1);

            if (membresia == null)
                return new List<Cuota>();
            
            //si no esta paga, la fecha debe ser menor a la fecha de vencimiento
            var cuotas = contexto.Cuota
               .Where(i => i.idMembresia == idMembresia 
               && !i.pagada
               && i.fechaVencimiento <= fecha
               ).ToList();

            return cuotas;
        }
    }
}
