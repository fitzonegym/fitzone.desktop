using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Fitzone.Entidades
{
    public class TipoMembresia
    {
        [Key]
        public int idTipoMembresia { get; set; }

        [MaxLength(50)]
        public string? nombre { get; set; }

        [MaxLength(500)]
        public string? descripcion { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal precioTotal { get; set; }

        public int cantidadCuotas { get; set; }

        public int cantidadDiasSemanales { get; set; }

        public string diasHabilitados { get; set; } = "";

        public TimeOnly horadesde { get; set; }
        public TimeOnly horaHasta { get; set; }

        public int? cupoClase { get; set; }

        [ForeignKey("Instructor")]
        public int? idInstructor { get; set; }
        public Instructor? Instructor { get; set; }

        [ForeignKey("Actividad")]
        public int idActividad { get; set; }
        public Actividad? Actividad { get; set; }

        [NotMapped]
        public string InstructorNombreCompleto
        {
            get
            {
                return Instructor == null ? "" : Instructor.NombreCompleto;
            }
        }
        [NotMapped]
        public string ActividadNombre
        {
            get
            {
                return Actividad == null ? "" : Actividad.nombre;
            }
        }

        [NotMapped]
        public string HoraDesdeString
        {
            get
            {
                return horadesde.ToShortTimeString();    
            }
        }

        [NotMapped]
        public string HoraHastaString
        {
            get
            {
                return horaHasta.ToShortTimeString();
            }
        }

    }
}
