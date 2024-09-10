using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class DetalleFactura
    {
        [Key]
        public int idDetalleFactura { get; set; }

        public int cantidad { get; set; }

        public string descripcion { get; set; } 

        [Column(TypeName = "decimal(8,2)")]
        public decimal precioUnitario { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal total { get; set; }

        [ForeignKey("Factura")]
        public int idFactura { get; set; }
        public Factura? Factura { get; set; }

        [ForeignKey("Cuota")]
        public int idCuota { get; set; }
        public Cuota? Cuota { get; set; }
    }
}
