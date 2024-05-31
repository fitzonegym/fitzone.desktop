using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class TipoEquipamiento
    {
        [Key]
        public int idTipoEquipamiento { get; set; }

        [MaxLength(50)]
        public string? descripcion { get; set; }

        [MaxLength(500)]
        public string? detalle { get; set; }
    }
}
