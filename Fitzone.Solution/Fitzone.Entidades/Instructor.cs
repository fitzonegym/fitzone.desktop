using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Instructor
    {
        #region Propiedades
        [Key]
        public int idInstructor { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }

        [MaxLength(50)]
        public string apellido { get; set; }

        [MaxLength(50)]
        public string telefono1 { get; set; }

        [MaxLength(50)]
        public string? telefono2 { get; set; }     

        [MaxLength(100)]
        public string? mail { get; set; }

        [MaxLength(10)]
        public string tipoDocumento { get; set; }

        [MaxLength(20)]
        public string numeroDocumento { get; set; }

        [MaxLength(100)]
        public string? calle { get; set; }
        [MaxLength(10)]
        public string? calleNumero { get; set; }
        public DateTime fechaAlta { get; set; } = DateTime.Now;
        public DateTime fechaNacimiento { get; set; } = DateTime.Now;   
        public bool anulado { get; set; } = false;
        
        public List<InstructorActividad> InstructorActividades { get; set; }        
        
        #endregion

        #region ForeignKey

        [ForeignKey("Barrio")]
        public int idBarrio { get; set; }
        public Barrio? Barrio { get; set; }        
      

        #endregion

        #region NotMapped

        public string NombreCompleto
        {
            get
            {
                return apellido + ", " + nombre;
            }
        }

        #endregion

    }
}
