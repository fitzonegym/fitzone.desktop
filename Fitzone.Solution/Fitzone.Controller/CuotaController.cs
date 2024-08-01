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
        Contexto? contexto = new Contexto();
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

        public List<Cuota>? GetAllByMembresiaFechaPagada(int idMembresia, DateTime fecha)
        {
            return contexto.Cuota
               .Where(i => i.idMembresia == idMembresia && fecha >= i.fechaDesde && fecha<=i.fechaVencimiento && i.pagada)
               .ToList();
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
