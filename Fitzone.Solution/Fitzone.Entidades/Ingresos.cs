using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitzone.Entidades
{
    public  class Ingresos
    {
        [Key]
        public int idIngresos {  get; set; }        
        public DateTime Entrada { get; set; }
        public DateTime? Salida { get; set; }

        [ForeignKey("Membresia")]
        public int? idMembresia { get; set; }        
        public Membresia Membresia { get; set; }        
        public bool IngresoAceptado { get; set; }
        public string? documento { get; set; }
        //[ForeignKey("Socio")]
        public int? idSocio { get; set; }        

        [MaxLength(250)]
        public string? detalle { get; set; }

        [NotMapped]
        public VerificarEstadoCuotaResponse respuesta { get; set; }

    }
}
