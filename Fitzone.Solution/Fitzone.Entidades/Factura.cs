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

        public string numero { get; set; }

        public string clienteNombre { get; set; }

        public string clienteDireccion { get; set; }

        public string tipoFactura { get; set; }

        public string letra { get; set; }

        //[ForeignKey("Socio")]
        public int idSocio{ get; set; }
            
        //public Socio? Socio { get; set; }

        public DateTime fecha { get; set; }

        [MaxLength(50)]
        public string? metodoDePago { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal total { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; } = new List<DetalleFactura>();
    }
}
