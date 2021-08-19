using Microsoft.EntityFrameworkCore;
using RedeSocial.Core;
using RedeSocial.Core.Entidades;

namespace RedeSocial.Infrastructure.EntityFramework
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions options) : base(options) { }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}
