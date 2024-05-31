using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public decimal total { get; set; }
    }
}
