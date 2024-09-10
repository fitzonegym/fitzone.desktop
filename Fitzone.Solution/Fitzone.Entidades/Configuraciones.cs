using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Configuraciones
    {
        public int id {  get; set; }    
        public string nombre { get; set; }    
        public string valor { get; set;}
        public static DateTime fechaHoy { get; set; } = DateTime.Now;        

    }
}
