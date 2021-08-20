using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RedeSocial.Core;
using RedeSocial.Core.Entidades;
using System.IO;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options) { }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Post> Post { get; set; }
    }


    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BancoDeDados>
    {
        public BancoDeDados CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile
            //(@Directory.GetCurrentDirectory() +
            //"/../MyCooking.MVC/appsettings.json").Build();
            //var builder = new DbContextOptionsBuilder<BancoDeDados>();
            //var connectionString = configuration.GetConnectionString("database");
            //builder.UseSqlServer(connectionString);
            //return new BancoDeDados(builder.Options);

            return null;
        }
    }
}
