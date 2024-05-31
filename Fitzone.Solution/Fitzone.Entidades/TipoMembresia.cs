using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [MaxLength(500)]
        public string? detalle { get; set; }
    }
}
