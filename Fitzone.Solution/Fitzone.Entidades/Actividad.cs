using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Actividad
    {
        [Key]
        public int idActividad { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }

        public ICollection<InstructorActividad> InstructorActividades { get; set; }

    }
}
