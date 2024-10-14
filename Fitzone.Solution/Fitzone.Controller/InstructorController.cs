using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public class InstructorController : IControllerClasesAuxiliares<Instructor>
    {
        Contexto contexto = new Contexto();
        public List<Instructor>? GetAll()
        {
            return contexto.Instructor
               .Where(i => i.anulado == false)
               .OrderBy(i=>i.apellido)
               .ToList();
        }
        public List<Instructor>? GetAll(Instructor instructor, bool verAnulados = false)
        {
            var instructores = contexto.Instructor               
               .Where(i => i.nombre.Contains(instructor.nombre))
               .Where(i => i.apellido.Contains(instructor.apellido))
               .Where(i => i.numeroDocumento.Contains(instructor.numeroDocumento))
               .OrderBy(i => i.apellido)
               .Include(i => i.InstructorActividades)       // Incluye la relación intermedia
               .ThenInclude(ia => ia.Actividad)
               .ToList();


            if (!verAnulados)
                instructores = instructores
                    .Where(c => !c.anulado)
                    .ToList();

            return instructores;
        }

        public Instructor? GetById(int id)
        {
            var inst =  contexto.Instructor
                .Include("Barrio")
                .Include("InstructorActividades")                
                .FirstOrDefault(i => i.idInstructor == id);
            if (inst == null)
                return null;

            foreach (var item in inst.InstructorActividades)
            {
                item.ActividadNombre = contexto.Actividad.First(c => c.idActividad == item.idActividad).nombre;
            }

            return inst;   
        }
        public Instructor? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }           
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
            entidad.idInstructor = 0;
            try
            {
                //validar que no se repita el DNI
                var existente = contexto.Instructor
                    .Include("InstructorActividades")
                    .FirstOrDefault(i => i.numeroDocumento == entidad.numeroDocumento);
                if (existente != null)
                {
                    //existe el DNI
                    string m = string.Format("El instructor ya existe [DNI {0}]", existente.numeroDocumento);
                    throw new Exception(m);

                }
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool Update(Instructor entidad, int id)
        {
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.Instructor.Include("InstructorActividades")
                    .FirstOrDefault(i => i.idInstructor == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.nombre = entidad.nombre;
                actualizar.apellido = entidad.apellido;
                actualizar.calle = entidad.calle;
                actualizar.calleNumero = entidad.calleNumero;
                actualizar.tipoDocumento = entidad.tipoDocumento;
                actualizar.numeroDocumento = entidad.numeroDocumento;
                actualizar.mail = entidad.mail;


                actualizar.telefono1 = entidad.telefono1;
                actualizar.telefono2 = entidad.telefono2;
                actualizar.idBarrio = entidad.idBarrio;

                actualizar.fechaNacimiento = entidad.fechaNacimiento;

                actualizar.InstructorActividades = entidad.InstructorActividades;


                //foreach (var ent in entidad.InstructorActividades)
                //{
                //    var i = 
                //}


                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }    
        public bool PuedeAnular(int idInstructor)
        {
            //se puede anular un instructor si NO tiene membresias activas o vencidas

            var membresiasActivas = contexto.Membresia.Where(m => m.idInstructor == idInstructor && (m.idEstadoMembresia == 1 || m.idEstadoMembresia == 2)).ToList();

            return membresiasActivas.Count == 0;
        }

        public bool Anular(int id)
        {
            try
            {
                //busco en la BD el objeto a anular
                var instructor = contexto.Instructor.FirstOrDefault(i => i.idInstructor == id);
                if (instructor == null)
                    return false;

                //actualizo los valores
                instructor.anulado = true;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
