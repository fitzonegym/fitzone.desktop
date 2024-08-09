using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public  class GeneralesController
    {
        Contexto contexto = new Contexto();

        public List<Actividad>? GetActividad()=>        
            contexto.Actividad.ToList();

        
    }
}
