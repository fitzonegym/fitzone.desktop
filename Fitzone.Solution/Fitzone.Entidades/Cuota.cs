using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class Cuota
    {
        [Key]
        public int idCuota { get; set; }

        public decimal precioCuota { get; set; }

        public int numeroCuota { get; set; }

        public DateTime fechaDesde { get; set; }

        public DateTime fechaHasta { get; set; }
    }
}
