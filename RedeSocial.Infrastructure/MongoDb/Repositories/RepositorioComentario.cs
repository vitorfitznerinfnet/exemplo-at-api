using RedeSocial.Core;
using RedeSocial.Core.Entidades;
using RedeSocial.Infrastructure.EntityFramework;
using System;

namespace RedeSocial.Infrastructure.MongoDb.Repositories
{
    public class RepositorioComentario : IRepositorioComentario
    {
        public Comentario BuscarComentarioPelo(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remover(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Comentario comentario)
        {
            throw new NotImplementedException();
        }
    }

    //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    //{
    //    public ApplicationDbContext CreateDbContext(string[] args)
    //    {
    //        IConfigurationRoot configuration = new
    //        ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile
    //        (@Directory.GetCurrentDirectory() +
    //        "/../MyCooking.MVC/appsettings.json").Build();
    //        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
    //        var connectionString =
    //        configuration.GetConnectionString("DatabaseConnection");
    //        builder.UseSqlServer(connectionString);
    //        return new ApplicationDbContext(builder.Options);
    //    }
    //}
}
