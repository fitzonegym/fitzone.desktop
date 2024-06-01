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
        [Key]
        public int idInstructor { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }

        [MaxLength(50)]
        public string? telefono { get; set; }

        [MaxLength(100)]
        public string? mail { get; set; }

        [MaxLength(10)]
        public string tipoDocumento { get; set; }

        [MaxLength(20)]
        public string numeroDocumento { get; set; }

        [ForeignKey("Barrio")]
        public int idBarrio { get; set; }
        public Barrio? Barrio { get; set; }

        public bool anulado { get; set; } = false;
    }
}
