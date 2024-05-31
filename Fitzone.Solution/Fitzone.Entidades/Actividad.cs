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
        public string? nombreActividad { get; set; }

        [MaxLength(500)]
        public string? detalleActividad { get; set; }

        [MaxLength(1000)]
        public string? descripcion { get; set; }
    }
}
