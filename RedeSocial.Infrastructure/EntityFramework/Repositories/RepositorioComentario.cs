using RedeSocial.Core;
using RedeSocial.Core.Entidades;
using System;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class RepositorioComentario : IRepositorioComentario
    {
        public RepositorioComentario(BancoDeDados bancoDeDados)
        {
            this.bancoDeDados = bancoDeDados;
        }

        public BancoDeDados bancoDeDados { get; }

        public Comentario BuscarComentarioPelo(Guid id)
        {
            return bancoDeDados.Comentario.Find(id);
        }

        public void Remover(Comentario comentario)
        {
            bancoDeDados.Remove(comentario);
            bancoDeDados.SaveChanges();
        }

        public void Salvar(Comentario comentario)
        {
            bancoDeDados.Comentario.Add(comentario);
            bancoDeDados.SaveChanges();
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
