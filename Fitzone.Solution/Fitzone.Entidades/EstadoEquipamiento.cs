﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitzone.Entidades
{
    public class EstadoEquipamiento
    {
        [Key]
        public int idEstadoEquipamiento { get; set; }

        [MaxLength(50)]
        public string? nombre { get; set; }
      
    }
}
