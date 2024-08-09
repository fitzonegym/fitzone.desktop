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
    }
}
