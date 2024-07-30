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
        public string? nombre { get; set; }
        
        [MaxLength(50)]
        public string? dimensiones { get; set; }


        [MaxLength(100)]
        public string? modelo { get; set; }

        [ForeignKey("EstadoEquipamiento")]
        public int idEstadoEquipamiento { get; set; }
        public EstadoEquipamiento? EstadoEquipamiento { get; set; }

        [ForeignKey("Marca")]
        public int idMarca { get; set; }
        public Marca? Marca { get; set; }
    }
}
