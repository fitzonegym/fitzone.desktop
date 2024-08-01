using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public enum EnumEstadoCuotaSocio
    {
        No_se_encontró_el_socio = 0,
        Cuota_al_dia = 1,
        Cuota_proxima_a_vencer = 2,
        Cuota_vencida = 3,
        Problemas_con_la_membresía = 4,
        No_se_encontró_la_membresía = 0,

    }
}
