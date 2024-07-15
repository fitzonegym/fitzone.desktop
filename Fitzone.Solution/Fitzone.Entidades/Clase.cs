using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Clase
    {
        [Key]
        public int idClase { get; set; }

        [MaxLength(50)]
        public string nombreClase { get; set; }

        [MaxLength(5)]
        public string codigoClase { get; set; }        

        public DateTime fechaInicio { get; set; }

        public DateTime horadesde { get; set; }        

        public DateTime horaHasta { get; set; }

        public int cupoClase { get; set; }

        [ForeignKey("Instructor")]
        public int idInstructor { get; set; }
        public Instructor? Instructor { get; set; }

        [ForeignKey("Actividad")]
        public int idActividad { get; set; }
        public Actividad? Actividad { get; set; }
        
        public List<Equipamiento>? Equipamientos { get; set; }
    }
}
