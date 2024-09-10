using Fitzone.EF;
using Fitzone.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public  class ConfiguracionesController
    {
        Contexto contexto = new Contexto();
        public string? GetValueByName(string name)
        {
            return contexto.Configuraciones.FirstOrDefault(i => i.nombre.ToUpper() == name.ToUpper())?.valor;            

        }
    }
}
