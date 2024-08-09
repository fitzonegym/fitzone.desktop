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
    public class BarrioController : IControllerClasesAuxiliares<Barrio>
    {
        Contexto contexto = new Contexto();      

        public List<Barrio>? GetAll()
        {
            return contexto.Barrio.ToList();
        }

        public Barrio? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Barrio? GetByName(string nombre)
        {
            return contexto.Barrio.FirstOrDefault(i => i.nombre.Contains(nombre) );
        }

        public bool Insert(Barrio entidad)
        {
            entidad.idBarrio = 0;
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
    }
}
