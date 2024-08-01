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
    public class InstructorController : IControllerClasesAuxiliares<Instructor>
    {
        Contexto? contexto = new Contexto();
        public List<Instructor>? GetAll()
        {
            return contexto.Instructor
               .Where(i => i.anulado == false)
               .OrderBy(i=>i.apellido)
               .ToList();
        }

        public Instructor? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        //public List<Instructor>? GetByActividad(int pIdActividad)
        //{
        //    return contexto.Instructor
        //       .Where(i => i.anulado == false)
        //       .ToList();
        //}

        public List<Instructor>? GetInstructoresActividad(int idActividad)
        {
           List<Instructor> lista = new List<Instructor>();

           var instructores = contexto.Instructor.Include("InstructorActividades").ToList();

            foreach (var instructor in instructores)
            {
             
                if (instructor.InstructorActividades.FirstOrDefault(i=>i.idActividad == idActividad) != null)                
                    lista.Add(instructor);
                                
            }

            return lista; 
        }



        public bool Insert(Instructor entidad)
        {
            throw new NotImplementedException();
        }

      


    }
}
