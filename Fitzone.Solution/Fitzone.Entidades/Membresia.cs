using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Membresia
    {
        [Key]
        public int idMembresia { get; set; }

        public decimal precioMembresia { get; set; }

        public DateTime fechaDesde { get; set; }

        public DateTime fechaHasta { get; set; }

        [MaxLength(500)]
        public string? detalleMembresia { get; set; }

        [ForeignKey("Cuota")]
        public int idCuota { get; set; }
        public Cuota? Cuota { get; set; }

        [ForeignKey("Socio")]
        public int idSocio { get; set; }
        public Socio? Socio { get; set; }

        [ForeignKey("EstadoMembresia")]
        public int idEstadoMembresia { get; set; }
        public EstadoMembresia? EstadoMembresia { get; set; }

        [ForeignKey("TipoMembresia")]
        public int idTipoMembresia { get; set; }
        public TipoMembresia? TipoMembresia { get; set; }
    }
}
