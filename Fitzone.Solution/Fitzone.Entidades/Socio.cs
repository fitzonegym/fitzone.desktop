using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitzone.Entidades
{
    public class Socio
    {
        /*
       decorados usados

          [Column("nombre_apellido")] 
          [Key]
          [NotMapped] 
          [ForeignKey("Departamento")]
       */

        [Key]
        public int idSocio { get; set; }
        [MaxLength(50)]
        public string? nombre { get; set; }
        [MaxLength(50)]
        public string? apellido { get; set; }
        [MaxLength(10)]
        public string? numeroDocumento { get; set; }
        [MaxLength(50)]
        public string? telefono1 { get; set; }
        [MaxLength(50)]
        public string? telefono2 { get; set; }
        [MaxLength(100)]
        public string? mail { get; set; }
        [MaxLength(20)]
        public string? tipoDocumento { get; set; }
        [MaxLength(100)]
        public string? calle { get; set; }
        [MaxLength(10)]
        public string? calleNumero{ get; set; }

        [ForeignKey("Barrio")] //EF
        public int idBarrio { get; set; }
        public Barrio? Barrio { get; set; }
        public bool anulado { get; set; } = false;
        
    }
}
