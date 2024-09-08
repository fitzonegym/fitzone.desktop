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
    public class ActividadController : IControllerClasesAuxiliares<Actividad>
    {
        Contexto contexto = new Contexto();

        public List<Actividad>? GetAll()
        {
            return contexto.Actividad                
                .ToList();
        }

        public Actividad? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actividad? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Actividad entidad)
        {
            throw new NotImplementedException();
        }

        
    }
}
