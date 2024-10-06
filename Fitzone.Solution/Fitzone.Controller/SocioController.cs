using Fitzone.Controller.Interfaces;
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
                .Where(i => socio.nombre == null || i.nombre.Contains(socio.nombre.Trim()))
                .Where(i => socio.apellido == null || i.apellido.Contains(socio.apellido.Trim()))
                .Where(i => socio.numeroDocumento == null || i.numeroDocumento.Contains(socio.numeroDocumento.Trim()))
                .ToList();    

            return listaresultado;
        }

        public List<Socio>? GetAll(Socio socio, DateTime? fechaDesde, DateTime? fechaHasta, bool verAnulados)
        {

            List<Socio>? listaresultado = new SocioController().GetAll(socio);

            if (listaresultado == null)
            {
                return new List<Socio>();   
            }

            listaresultado = listaresultado
                .Where(c => (fechaDesde != null && c.fechaAlta >= fechaDesde) || fechaDesde == null)
                .Where(c => (fechaHasta != null && c.fechaAlta <= fechaHasta) || fechaHasta == null)
                .ToList();

            if (!verAnulados)
                listaresultado = listaresultado
                    .Where(c => !c.anulado)
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

        public bool AnularHabilitar(int id, bool valor)
        {
            try
            {
                //busco en la BD el objeto a anular
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.anulado = valor;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public Ingresos VerificarEstadoCuota(string dni, DateTime fechaHoy)
        {
            /*
                public int idIngresos {  get; set; }        
                public DateTime Entrada { get; set; }
                public DateTime Salida { get; set; }
                public int idMembresia { get; set; }        
                public List<Membresia> Membresias { get; set; }        
                public bool IngresoAceptado { get; set; }
             */
            Ingresos ingresos = new Ingresos();          
            ingresos.Entrada = fechaHoy;
            ingresos.Salida = null;
            ingresos.documento = dni;

            Color rojo = Color.Red, amarillo = Color.Yellow, verde = Color.Green, gris = Color.Gray;

            ingresos.respuesta = new VerificarEstadoCuotaResponse();
            ingresos.IngresoAceptado = false;

            var socio = contexto.Socio
              .FirstOrDefault(s => s.anulado == false && s.numeroDocumento == dni);


            if (socio == null)
            {
                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.No_se_encontró_el_socio;
                ingresos.respuesta.Color = rojo;                
                return ingresos;
            }

            ingresos.idSocio = socio.idSocio;
            ingresos.respuesta.nombreSocio = socio.NombreCompleto;


            //si es salida, no hago nada mas
            var UltimaEntrada = new IngresosController().GetUltimoIngreso(socio.idSocio);
            if (UltimaEntrada != null && UltimaEntrada.Salida == null)
            {
                ingresos.Salida = fechaHoy;
                ingresos.idIngresos = UltimaEntrada.idIngresos;
                //caso exitoso
                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Salida;
                ingresos.respuesta.actividades = "-";
                ingresos.respuesta.Color = gris;

                return ingresos;
            }

            int minutosTolerancia = Statics.MinutosTolerancia;

            MembresiaController membresiaController = new MembresiaController();

            //membresias en la fecha establecida.
            var membresias = membresiaController.GetByIdSocioFecha(socio.idSocio, fechaHoy);
            if (membresias == null || membresias.Count == 0)
            {
                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.No_se_encontró_la_membresía;
                ingresos.respuesta.Color = rojo;                
                return ingresos;
            }


          

            //membresias en la fecha establecida y activas
            var membresiasActivas = membresias.Where(m => m.idEstadoMembresia == 1).ToList();
            if (membresiasActivas == null || membresiasActivas.Count == 0)
            {
                //no hay ninguna activa, ahora voy a buscar si es alguna vencida
                //membresias en la fecha establecida y activas
                bool vencida = membresias.Any(m => m.idEstadoMembresia == 2);
                if (vencida)
                {
                    ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Cuota_vencida;
                    ingresos.respuesta.Color = rojo;
                    return ingresos;
                }


                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Membresía_deshabilitada;
                ingresos.respuesta.Color = rojo;
                return ingresos;                
            }

            string diaDeLaSemana = Statics.DiaDeLaSemanaEnEspañol(fechaHoy);


            //membresias en la fecha establecida / activas / en horario
            var membresiasDentroHorarioDia = membresias.Where(m =>
                TimeOnly.FromDateTime(fechaHoy) >= m.horadesde.AddMinutes(-minutosTolerancia) 
                &&
                TimeOnly.FromDateTime(fechaHoy) <= m.horaHasta.AddMinutes(-minutosTolerancia)
                &&
                m.diasHabilitados.Contains(diaDeLaSemana)
                ).ToList();
            if (membresiasDentroHorarioDia == null || membresiasDentroHorarioDia.Count == 0)
            {
                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Fuera_de_día_horario;
                ingresos.respuesta.Color = rojo;

                ingresos.respuesta.actividades = GetTextoActividades(socio.idSocio,fechaHoy);

                return ingresos;
            }

            //membresias en la fecha establecida / activas / en horario
            CuotaController cuotaController = new CuotaController();
            TipoMembresiaController tipoMembresiaController = new TipoMembresiaController();

            bool encontroMembresia = false;
            ingresos.respuesta.actividades = "";
            /////////////filtro las que estan sin pagar///////////////
            
            foreach (var itemMembresia in membresiasDentroHorarioDia.OrderBy(i=>i.horadesde))
            {
                var cuota = cuotaController.GetAllByIdMembresiaFechaPagada(itemMembresia.idMembresia, fechaHoy);
                //si al menos encuentra una cuota vigente y pagada
                if (cuota!=null)
                {
                    string venc = cuota.fechaVencimiento.ToShortDateString();

                    //si esta todo bien, muestro el vencimiento de la proxima cuota
                    var cuotaSiguiente = cuotaController.GetProxima(itemMembresia.idMembresia, cuota.fechaDesde);
                    if (cuotaSiguiente != null)
                        venc = cuotaSiguiente.fechaVencimiento.ToShortDateString();

                    //caso exitoso
                    encontroMembresia = true;
                    var tipo = tipoMembresiaController.GetById(itemMembresia.idTipoMembresia);
                    ingresos.respuesta.actividades += tipo.ActividadNombre + "\n" + itemMembresia.horadesde + " hs a "  + itemMembresia.horaHasta +" hs | Días: " 
                        + Statics.ReducirDias(itemMembresia.diasHabilitados.Replace("[","").Replace("]","")) + " | Venc.: " + venc +  "\n ";

                    //agrego las membresias validas
                    ///lo ordeno por hora desde desc asi la ultima que toma sera un tipo que 
                    ///no sea de 00 a 23.59 (una clase de spinning por ejemplo)
                    ingresos.idMembresia = itemMembresia.idMembresia;

                }
            }

            ///////////// no tiene cuotas vigentes
            if (!encontroMembresia)
            {             
                ingresos.respuesta.Color = rojo;
                ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Cuota_vencida;
                ingresos.respuesta.actividades = GetTextoActividades(socio.idSocio, fechaHoy);

                return ingresos;
                
            }

            //caso exitoso
            ingresos.respuesta.EnumEstadoCuotaSocio = EnumEstadoCuotaSocio.Cuota_al_dia;
            ingresos.respuesta.actividades = ingresos.respuesta.actividades.Remove(ingresos.respuesta.actividades.Length - 2);
            ingresos.respuesta.Color = verde;

            ingresos.IngresoAceptado = true;

            return ingresos;
        }
        private string GetTextoActividades(int idSocio, DateTime fechaHoy)
        {
            //membresias en la fecha establecida.
            var membresias = new MembresiaController().GetByIdSocioFechaActivas(idSocio, fechaHoy);
            if (membresias == null || membresias.Count == 0)
            {              
                return "";
            }
            TipoMembresiaController tipoMembresiaController = new TipoMembresiaController();
            CuotaController cuotaController = new CuotaController();
            string actividades = "";
            foreach (var itemMembresia in membresias)
            {
                var tipo = tipoMembresiaController.GetById(itemMembresia.idTipoMembresia) ?? new TipoMembresia();                
                var cuota = cuotaController.GetAllByIdMembresiaFecha(itemMembresia.idMembresia, fechaHoy) ?? new Cuota();

                actividades += tipo.ActividadNombre + " " + itemMembresia.horadesde + " -> " + itemMembresia.horaHasta + " | Vencimiento: " + cuota.fechaVencimiento.ToShortDateString() + "\n";
            }
         

            return actividades;
        }
        public void ActualizarEstadoDeudor(int idSocio, DateTime fecha)
        {
            //si el socio tiene una o mas membresias con cuotas vencidas le cambio el estado al socio
            var socio = contexto.Socio.FirstOrDefault(s => s.idSocio == idSocio);

            if (socio == null)
                return;

            new MembresiaController().ProcesarEstadoMembresias(fecha);

            var membresiavencida = contexto.Membresia.FirstOrDefault(m=>m.idSocio == idSocio && m.idEstadoMembresia == (int)EstadoMembresiaEnum.Vencida);
            if (membresiavencida == null)
            {
                socio.deudor = false;
            }

            contexto.SaveChanges();


        }

        public void ActualizarEstadoDeudorTodos(DateTime fecha)
        {
            //si el socio tiene una o mas membresias con cuotas vencidas le cambio el estado al socio
            var socios = contexto.Socio.ToList();

            foreach (var socio in socios)
            {
                ActualizarEstadoDeudor(socio.idSocio, fecha);
            }

        }
        

    }
}
