using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitzone.Entidades
{
    public class Usuario
    {

        [Key]
        public int idUsuario { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
        [MaxLength(50)]
        public string NombreUsuario { get; set; }        
        [MaxLength(256)] // Ampliar para almacenar hash
        public string Password { get; set; }
        public DateTime FechaAlta { get; set; } 
      
        [ForeignKey("Perfil")]
        public int idPerfil { get; set; }   
        public Perfil Perfil { get; set; }  
        /*
         1-admin
            hace todo
         2-control accesos
            solo se puede abrir el control de accesos
         3-operador
            todo menos configuraciones y reportes
         4-director
            todo 
         */
    }

    public enum EnumPerfil
    {
        Administrador = 1,
        Control_accesos = 2,
        Operador = 3,
        Gerente = 4
    }

}
