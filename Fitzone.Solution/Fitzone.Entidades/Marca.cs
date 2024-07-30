using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Marca
    {
        [Key]
        public int idMarca { get; set; }
        [MaxLength(50)]
        public string nombre { get; set; }
    }
}
