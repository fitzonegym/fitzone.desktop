using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitzone.Controller
{
    public class IngresosController : IControllersClasesPrincipales<Ingresos>
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

        public List<Ingresos>? GetAll()
        {
            throw new NotImplementedException();
        }

        public Ingresos? GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Ingresos? GetUltimoIngreso(int idSocio)
        {

            //usar take
            return contexto.Ingresos
                           .Where(i => i.idSocio == idSocio && i.IngresoAceptado)
                           .OrderByDescending(i => i.idIngresos)
                            .FirstOrDefault();  
                        
        }
        public Ingresos? GetSalidaByIdSocio(int idSocio)
        {
            try
            {
                return contexto.Ingresos.FirstOrDefault(i => i.idSocio == idSocio && i.Salida == null);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Ingresos? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Ingresos entidad)
        {
            entidad.idIngresos = 0;
            try
            { 
                entidad.detalle = entidad.respuesta.EnumEstadoCuotaSocio.ToString().Replace("_", " ");
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Ingresos entidad, int id)
        {
            throw new NotImplementedException();
        }
        public bool UpdateSalida(Ingresos entidad, int id)
        {
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.Ingresos.FirstOrDefault(i => i.idIngresos == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores                
                actualizar.Salida = entidad.Salida;
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
