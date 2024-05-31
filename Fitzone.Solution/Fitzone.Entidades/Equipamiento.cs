using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Equipamiento
    {
        [Key]
        public int idEquipamiento { get; set; }

        [MaxLength(50)]
        public string? tamaño { get; set; }

        [MaxLength(50)]
        public string? dimensiones { get; set; }

        [MaxLength(100)]
        public string? marca { get; set; }

        [MaxLength(100)]
        public string? modelo { get; set; }

        [ForeignKey("TipoEquipamiento")]
        public int idTipoEquipamiento { get; set; }
        public TipoEquipamiento? TipoEquipamiento { get; set; }
    }
}
