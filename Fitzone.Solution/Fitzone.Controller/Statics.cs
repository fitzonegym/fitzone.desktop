using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Controller
{
    public class Statics
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
    }
}
