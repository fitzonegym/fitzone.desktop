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
    public class MembresiaController : IControllersClasesPrincipales<Membresia>
    {
        Contexto? contexto = new Contexto();
        public MembresiaController() { }

        public bool Anular(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Membresia>? GetAll()
        {
            return contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")
                .Include("TipoMembresia")
                .OrderByDescending(c => c.fechaAlta).ToList();
        }
        public List<Membresia>? GetAll(Membresia membresia)
        {
            return contexto.Membresia
                .Include("Socio")
                .Include("EstadoMembresia")
                .Include("TipoMembresia")
                .Where(c => c.idSocio == membresia.idSocio || membresia.idSocio == 0)
                .Where(c => c.fechaAlta >= membresia.fechaDesde && c.fechaAlta <= membresia.fechaHasta)                
                .OrderByDescending(c => c.fechaAlta)
                .ToList();
        }

        public Membresia? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Membresia? GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Membresia entidad)
        {
            entidad.idMembresia = 0;
            try
            {
                ////validar que no se repita el DNI
                //var existente = contexto.Membresia.FirstOrDefault(i => i.numeroDocumento == entidad.numeroDocumento);
                //if (existente != null)
                //{
                //    //existe el DNI
                //    throw new Exception("El socio ya existe [DNI]");

                //}
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Membresia entidad, int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoMembresia>? GetAllTipoMembresia()
        {
            return contexto.TipoMembresia.OrderBy(c=>c.nombre).ToList();
        }
    }
}
