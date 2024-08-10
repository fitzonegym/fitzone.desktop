using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace Fitzone.EF
{
    public class ApplicationDesignTimeDbContextFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Fitzone04;integrated security=true;TrustServerCertificate=true");
            return new Contexto(optionsBuilder.Options);
        }
    }
}
