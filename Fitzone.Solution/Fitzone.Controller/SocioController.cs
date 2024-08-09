﻿using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;

namespace Fitzone.Controller
{
    public class SocioController : IControllersClasesPrincipales<Socio>
    {
        Contexto contexto = new Contexto();


        /// <summary>
        /// Obtener todos los socios
        /// </summary>
        /// <returns></returns>
        public List<Socio>? GetAll()
        {
            return contexto.Socio.Include("Barrio")
                .Where(i => i.anulado == false)
                .ToList();
        }

        public List<Socio>? GetAll(Socio socio)
        {
            
            var listaresultado = contexto.Socio.Include("Barrio")
                .Where(i => i.anulado == false)
                .Where(i => socio.nombre == null || i.nombre.Contains(socio.nombre.Trim()))
                .Where(i => socio.apellido == null || i.apellido.Contains(socio.apellido.Trim()))
                .Where(i => socio.numeroDocumento == null || i.numeroDocumento.Contains(socio.numeroDocumento.Trim()))
                .ToList();    

            return listaresultado;
        }

        public List<Socio>? GetAll(Socio socio, DateTime? fechaDesde, DateTime? fechaHasta)
        {

            List<Socio>? listaresultado = new SocioController().GetAll(socio);

            if (listaresultado == null)
            {
                return new List<Socio>();   
            }

            listaresultado = listaresultado
                .Where(c => (fechaDesde != null && c.fechaAlta >= fechaDesde) || fechaDesde == null)
                .Where(c => (fechaHasta != null && c.fechaAlta <= fechaHasta) || fechaHasta == null)
                .Where(c => !c.anulado )
                .ToList();

            return listaresultado;
        }

        /// <summary>
        /// Obtener el socio con un ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Socio? GetById(int id)
        {
            return contexto.Socio.Include("Barrio").FirstOrDefault(i=>i.idSocio == id);
        }

        /// <summary>
        /// Obtener el primer socio que contenga el texto en el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Socio? GetByName(string nombre)
        {
            return contexto.Socio.Include("Barrio").FirstOrDefault(i => i.nombre.Contains(nombre));
        }

        /// <summary>
        /// insertar un socio
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public bool Insert(Socio entidad)
        {
            entidad.idSocio = 0;
            try
            {
                //validar que no se repita el DNI
                var existente = contexto.Socio.FirstOrDefault(i => i.numeroDocumento == entidad.numeroDocumento);
                if (existente != null)
                {
                    //existe el DNI
                    string m = string.Format("El socio ya existe [DNI {0}]", existente.numeroDocumento);
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

        /// <summary>
        /// Actualizar un socio
        /// </summary>
        /// <param name="entidad"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Update(Socio entidad, int id)
        {
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
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
                actualizar.imagen = entidad.imagen;

                actualizar.telefono1 = entidad.telefono1;
                actualizar.telefono2 = entidad.telefono2;
                actualizar.idBarrio = entidad.idBarrio;

                actualizar.fechaNacimiento = entidad.fechaNacimiento;


                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Borrar un socio
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            //Esto borra definitivamente de la BD
            try
            {
                //busco en la BD el objeto a eliminar
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                contexto.Remove(actualizar);                

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Anular un socio, actualizar el campo anualdo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Anular(int id)
        {
            try
            {
                //busco en la BD el objeto a anular
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.anulado = true;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    
        public VerificarEstadoCuotaResponse VerificarEstadoCuota(string dni, DateTime fecha)
        {

            Color rojo = Color.Red, amarillo = Color.Yellow, verde = Color.Green;

            VerificarEstadoCuotaResponse respuesta = new VerificarEstadoCuotaResponse();

            var socio = contexto.Socio
              .FirstOrDefault(s => s.anulado == false && s.numeroDocumento == dni);


            if (socio == null)
            {
                respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.No_se_encontró_el_socio;
                respuesta.Color = rojo;
                return respuesta;
            }

            respuesta.nombreSocio = socio.NombreCompleto;

            MembresiaController membresiaController = new MembresiaController();
            var membresias = membresiaController.GetByIdSocioFecha(socio.idSocio, fecha);
            if (membresias == null || membresias.Count == 0)
            {
                respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.No_se_encontró_la_membresía;
                respuesta.Color = rojo;
                return respuesta;
            }
            var membresiasActivas = membresias.Where(m => m.idEstadoMembresia == 1);
            if (membresiasActivas == null || membresiasActivas.Count() == 0)
            {
                respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Problemas_con_la_membresía;
                respuesta.Color = rojo;
                return respuesta;                
            }

            var membresiasFueraHorarioDia = membresias.Where(m =>
                TimeOnly.FromDateTime(fecha) >= m.horadesde 
                &&
                TimeOnly.FromDateTime(fecha) <= m.horaHasta
                );
            if (membresiasFueraHorarioDia == null || membresiasFueraHorarioDia.Count() == 0)
            {
                respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Fuera_de_horario;
                respuesta.Color = rojo;
                return respuesta;
            }


            //tiene al menos 1 membresia vigente y activa
            CuotaController cuotaController = new CuotaController();
            TipoMembresiaController tipoMembresiaController = new TipoMembresiaController();

            bool encontroMembresia = false;
            respuesta.actividades = "";
              
            foreach (var itemMembresia in membresias)
            {
                var cuota = cuotaController.GetAllByIdMembresiaFechaPagada(itemMembresia.idMembresia, fecha);
                //si al menos encuentra una cuota vigente y pagada
                if (cuota!=null)
                {
                    encontroMembresia = true;
                    var tipo = tipoMembresiaController.GetById(itemMembresia.idTipoMembresia);
                    respuesta.actividades += tipo.ActividadNombre + " | Vencimiento: " + cuota.fechaVencimiento.ToShortDateString() +  " | ";

                }
            }

            if (!encontroMembresia)
            {
                respuesta.Color = rojo;
                respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Cuota_vencida;
                return respuesta;
                
            }
            respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Cuota_al_dia;
            respuesta.actividades = respuesta.actividades.Remove(respuesta.actividades.Length - 2);
            respuesta.Color = verde;

            return respuesta;
        }
    
    }
}
