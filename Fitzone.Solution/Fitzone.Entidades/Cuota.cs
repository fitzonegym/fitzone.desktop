using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Cuota
    {
        [Key]
        public int idCuota { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal precio{ get; set; }        
        public int numero{ get; set; }

        public DateTime fechaDesde { get; set; }

        public DateTime fechaHasta { get; set; }

        public DateTime fechaVencimiento { get; set; }

        public bool pagada { get; set; }

        [ForeignKey("Membresia")]
        public int idMembresia { get; set; }
        public Membresia? Membresia { get; set; }

        [NotMapped]
        public bool seleccionada { get; set; }
    }
}
