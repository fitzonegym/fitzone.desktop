using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fitzone.Entidades
{
    public class InstructorActividad
    {
        [Key]
        public int id { get; set; }       

        [ForeignKey("Instructor")] //EF
        public int idInstructor { get; set; }
        //public required Instructor Instructor { get; set; }
        public Instructor Instructor { get; set; }

        [ForeignKey("Actividad")] //EF
        public int idActividad { get; set; }
        //        public required Actividad Actividad { get; set; }
        public Actividad Actividad { get; set; }

        #region NotMapped

        [NotMapped]
        public string  ActividadNombre { get; set; }
    

        #endregion
    }
}
