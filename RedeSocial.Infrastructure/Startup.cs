using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Core;
using RedeSocial.Infrastructure.EntityFramework;

namespace RedeSocial.Infrastructure
{
    public static class Startup
    {
        public static void AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<BancoDeDados>(options => options.UseSqlServer(connectionString));
            //services.AddDbContext<BancoDeDados>(options => options.UseInMemoryDatabase("teste"));

            services.AddScoped<IRepositorioPessoa, RepositorioPessoa>();
            services.AddScoped<IRepositorioComentario, RepositorioComentario>();
            services.AddScoped<IRepositorioPost, RepositorioPost>();
        }
    }
}
