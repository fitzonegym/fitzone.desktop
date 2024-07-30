using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class EquipamientoTipoMembresia
    {
        [Key]
        public int idexc { get; set; }

        [ForeignKey("Equipamiento")]
        public int idEquipamiento { get; set; }
        public Equipamiento? Equipamiento { get; set; }

        [ForeignKey("TipoMembresia")]
        public int idTipoMembresia { get; set; }
        public TipoMembresia? TipoMembresia { get; set; }
        public int cantidadEquipamiento { get; set; }
    }
}
