using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public  class Ingresos
    {
        [Key]
        public int idIngresos {  get; set; }        
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
        public int idMembresia { get; set; }        
        public List<Membresia> Membresias { get; set; }

        

    }
}
