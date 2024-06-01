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

        public DateTime fecha { get; set; }

        public DateTime hora { get; set; }

        public int cupoClase { get; set; }

        [ForeignKey("Instructor")]
        public int idInstructor { get; set; }
        public Instructor? Instructor { get; set; }

        [ForeignKey("Actividad")]
        public int idActividad { get; set; }
        public Actividad? Actividad { get; set; }

        [ForeignKey("Equipamiento")]
        public int idEquipamiento { get; set; }
        public Equipamiento? Equipamiento { get; set; }
    }
}
