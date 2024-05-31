using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class EstadoMembresia
    {
        [Key]
        public int idEstadoMembresia { get; set; }

        [MaxLength(50)]
        public string? detalleEstado { get; set; }

        [MaxLength(500)]
        public string? descripcion { get; set; }
    }
}
