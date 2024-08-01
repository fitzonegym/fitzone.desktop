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
    public class TipoMembresiaController : IControllersClasesPrincipales<TipoMembresia>
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

        public List<TipoMembresia>? GetAll()
        => contexto.TipoMembresia.Include("Instructor").Include("Actividad").OrderBy(c => c.nombre).ToList();
        

        public TipoMembresia? GetById(int id)
         => contexto.TipoMembresia.Include("Actividad").FirstOrDefault(c => c.idTipoMembresia == id);

        public TipoMembresia? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TipoMembresia entidad)
        {
            entidad.idTipoMembresia = 0;
            try
            {            
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(TipoMembresia entidad, int id)
        {
            throw new NotImplementedException();
        }
    }
}
