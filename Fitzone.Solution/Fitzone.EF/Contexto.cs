using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Fitzone.EF
{
    public  class Contexto : DbContext
    {
        public DbSet<Socio> Socio { get; set; }
        public DbSet<Barrio> Barrio{ get; set; }
        public DbSet<EstadoMembresia> EstadoMembresia { get; set; }
        public DbSet<TipoMembresia> TipoMembresia { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Cuota> Cuota { get; set; }        
        public DbSet<Actividad> Actividad{ get; set; }
        public DbSet<Instructor> Instructor { get; set; }        
        public DbSet<Equipamiento> Equipamiento { get; set; }        
        public DbSet<EquipamientoTipoMembresia> EquipamientoTipoMembresia { get; set; }
        public DbSet<EstadoEquipamiento> EstadoEquipamiento { get; set; }

        public DbSet<Marca> Marca { get; set; }



        public DbSet<Configuraciones> Configuraciones { get; set; }

        public Contexto() { }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                optionsBuilder.UseSqlServer(connString);
            }
        }
    }

   

}
