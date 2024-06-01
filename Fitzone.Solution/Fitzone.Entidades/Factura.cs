using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Factura
    {
        [Key]
        public int idFactura { get; set; }

        public DateTime fecha { get; set; }

        [MaxLength(50)]
        public string? metodoDePago { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal total { get; set; }
    }
}
