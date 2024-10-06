using Fitzone.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public static class Statics
    {
        public static string DiaDeLaSemanaEnEspañol(DateTime fecha)
        {
            // Returns the day-of-week part of this DateTime. The returned value
            // is an integer between 0 and 6, where 0 indicates Sunday, 1 indicates
            // Monday, 2 indicates Tuesday, 3 indicates Wednesday, 4 indicates
            // Thursday, 5 indicates Friday, and 6 indicates Saturday.

            int dia = (int)fecha.DayOfWeek;
            switch (dia)
            {
                case 0:
                    return "domingo";
                case 1:
                    return "lunes";
                case 2:
                    return "martes";
                case 3:
                    return "miercoles";
                case 4:
                    return "jueves";
                case 5:
                    return "viernes";
                case 6:
                    return "sabado";
            }
            return "noEncontrado";

        }
        public static string ReducirDias(string diasSemana)
        {
            // Dividir el string de entrada por coma para obtener un array de días
            string[] dias = diasSemana.ToUpper().Split(',');

            // Usar LINQ para seleccionar la primera letra de cada día y luego unirlas por comas
            string iniciales = string.Join(",", dias.Select(dia => dia.Trim()[0]));

            return iniciales;

        }

        private static int _MinutosTolerancia = 0;
        public static int MinutosTolerancia
        {
            get
            {
                if (_MinutosTolerancia == 0)
                {
                    Contexto contexto = new Contexto();
                    _MinutosTolerancia = Convert.ToInt16(contexto.Configuraciones.FirstOrDefault(c => c.nombre == "MinutosTolerancia").valor);
                }
                return _MinutosTolerancia;
            }
            set{ _MinutosTolerancia = value; }
        }

        private static int _AniosMinimoSocio = 0;
        public static int AniosMinimoSocio
        {
            get
            {
                if (_AniosMinimoSocio == 0)
                {
                    Contexto contexto = new Contexto();
                    _AniosMinimoSocio = Convert.ToInt16(contexto.Configuraciones.FirstOrDefault(c => c.nombre == "AniosMinimoSocio").valor);
                }
                return _AniosMinimoSocio;
            }
            set { _AniosMinimoSocio = value; }
        }


    }
}
