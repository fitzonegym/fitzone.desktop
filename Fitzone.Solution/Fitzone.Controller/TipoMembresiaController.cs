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
        Contexto contexto = new Contexto();

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
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.TipoMembresia.FirstOrDefault(i => i.idTipoMembresia == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.nombre = entidad.nombre;
                actualizar.diasHabilitados = entidad.diasHabilitados;
                actualizar.idActividad = entidad.idActividad;
                actualizar.cantidadCuotas = entidad.cantidadCuotas;
                actualizar.cuotaUnica = entidad.cuotaUnica;
                //actualizar.cantidadDiasSemanales = entidad.cantidadDiasSemanales;
                actualizar.cupoClase = entidad.cupoClase;
                actualizar.descripcion = entidad.descripcion;

                actualizar.horadesde = entidad.horadesde;
                actualizar.horaHasta = entidad.horaHasta;
                actualizar.precioTotal = entidad.precioTotal;

                actualizar.idInstructor = entidad.idInstructor;                

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
