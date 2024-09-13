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
        public DbSet<InstructorActividad> InstructorActividad { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        public DbSet<Ingresos> Ingresos { get; set; }        
        public DbSet<Usuario> Usuario { get; set; }
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>()
                  .HasMany(i => i.InstructorActividades)
                  .WithOne(ia => ia.Instructor)  // Indica que InstructorActividad tiene una referencia a Instructor
                  .HasForeignKey(ia => ia.idInstructor)
                  .OnDelete(DeleteBehavior.Cascade);  // Configura eliminación en cascada


            modelBuilder.Entity<InstructorActividad>()
                .HasOne(ia => ia.Instructor)
                .WithMany(i => i.InstructorActividades)
                .HasForeignKey(ia => ia.idInstructor);

            modelBuilder.Entity<InstructorActividad>()
                .HasOne(ia => ia.Actividad)
                .WithMany(a => a.InstructorActividades)
                .HasForeignKey(ia => ia.idActividad);

            modelBuilder.Entity<Membresia>()
              .HasOne(m => m.TipoMembresia)
              .WithMany()
              .HasForeignKey(m => m.idTipoMembresia)
              .OnDelete(DeleteBehavior.Restrict); // o .OnDelete(DeleteBehavior.NoAction)

        }

    }

   

}
