using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Core;
using RedeSocial.Infrastructure.EntityFramework;

namespace RedeSocial.Infrastructure
{
    public static class Startup
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<BancoDeDados>(options => options.UseInMemoryDatabase("dbteste"));

            services.AddScoped<IRepositorioPessoa, RepositorioPessoa>();
            services.AddScoped<IRepositorioComentario, RepositorioComentario>();
            services.AddScoped<IRepositorioPost, RepositorioPost>();
        }
    }
}
