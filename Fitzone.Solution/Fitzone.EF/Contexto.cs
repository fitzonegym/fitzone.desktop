using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Fitzone.EF
{
    public  class Contexto : DbContext
    {
        public DbSet<Socio> Socio { get; set; }
        public DbSet<Barrio> Barrio{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);

        }
    }
}
