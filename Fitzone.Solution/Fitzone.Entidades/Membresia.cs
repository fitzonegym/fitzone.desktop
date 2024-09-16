using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Fitzone.Entidades
{
    public class Membresia
    {
        [Key]
        public int idMembresia { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal precio{ get; set; }        
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime? fechaModificacion { get; set; } = null;
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        [MaxLength(1000)]
        public string? detalle{ get; set; }
        public List<Cuota>? Cuotas { get; set; }        
        public string diasHabilitados { get; set; } = "";

        public TimeOnly horadesde { get; set; }
        public TimeOnly horaHasta { get; set; }
                
        #region ForeignKey

        [ForeignKey("EstadoMembresia")]
        public int idEstadoMembresia { get; set; }
        public EstadoMembresia? EstadoMembresia { get; set; }                       

        [ForeignKey("Socio")]
        public int idSocio { get; set; }
        public Socio? Socio { get; set; }

        [ForeignKey("Instructor")]
        public int? idInstructor { get; set; }
        public Instructor? Instructor { get; set; }

        [ForeignKey("Actividad")]
        public int idActividad { get; set; }
        public Actividad? Actividad { get; set; }

        [ForeignKey("TipoMembresia")]
        public int idTipoMembresia { get; set; }
        public TipoMembresia? TipoMembresia { get; set; }


        #endregion

        #region No Mapped
        [NotMapped]
        public string? SocioNombre { get { return Socio != null ? Socio.nombre + " " + Socio.apellido : ""; }}

        [NotMapped]
        public string? EstadoMembresiaNombre { get { return EstadoMembresia != null ? EstadoMembresia.nombre : ""; } }

        [NotMapped]
        public string? TipoMembresiaNombre { get { return TipoMembresia != null ? TipoMembresia.nombre : ""; } }

        #endregion

    }
}
