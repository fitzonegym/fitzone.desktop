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
