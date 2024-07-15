using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitzone.Entidades
{
    public class Socio
    {
        #region Propiedades
        [Key]
        public int idSocio { get; set; }
        [MaxLength(50)]
        public string? nombre { get; set; }
        [MaxLength(50)]
        public string? apellido { get; set; }
        [MaxLength(8)]
        public string? numeroDocumento { get; set; }
        [MaxLength(50)]
        public string telefono1 { get; set; }
        [MaxLength(50)]
        public string? telefono2 { get; set; }
        [MaxLength(100)]
        public string? mail { get; set; }
        [MaxLength(20)]
        public string? tipoDocumento { get; set; }
        [MaxLength(100)]
        public string? calle { get; set; }
        [MaxLength(10)]
        public string? calleNumero { get; set; }
        public bool anulado { get; set; } = false;
        public byte[]? imagen { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime fechaNacimiento { get; set; } = DateTime.Now;


        #endregion

        #region ForeignKey
        [ForeignKey("Barrio")] //EF
        public int idBarrio { get; set; }
        public Barrio? Barrio { get; set; }

        #endregion

        #region NotMapped
        [NotMapped]
        public string BarrioNombre
        {
            get
            {
                return Barrio == null ? "" : Barrio.nombre;
            }
        }

        [NotMapped]
        public string NombreCompleto
        {
            get
            {
                return apellido + ", " + nombre;
            }
        }

        [NotMapped]
        public bool TieneImagen
        {
            get
            {
                return imagen == null ? false : true;
            }
        }

        #endregion
    }
}
