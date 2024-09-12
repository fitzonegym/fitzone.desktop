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
        Membresía_deshabilitada = 4,
        No_se_encontró_la_membresía = 5,
        Fuera_de_día_horario = 6,
        Salida = 7

    }
}
