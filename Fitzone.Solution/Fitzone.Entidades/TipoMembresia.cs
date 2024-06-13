using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitzone.Entidades
{
    public class TipoMembresia
    {
        [Key]
        public int idTipoMembresia { get; set; }

        [MaxLength(50)]
        public string? nombre { get; set; }

        [MaxLength(500)]
        public string? descripcion { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal precioTotal { get; set; }
        
        public int cantidadCuotas { get; set; }

        public int cantidadDiasSemanales { get; set; }

        public string diasHabilitados { get; set; } = "";

    }
}
