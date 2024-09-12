using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public  class VerificarEstadoCuotaResponse
    {
        public string actividades {  get; set; }    
        public string vencimientos { get; set; }
        public string nombreSocio { get; set; }
        public EnumEstadoCuotaSocio EnumEstadoCuotaSocio { get; set; } 
        public Color Color { get; set; }        

    }
}
