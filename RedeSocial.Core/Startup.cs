using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial.Core
{
    public static class Startup
    {
        public static void AddApplicationCore(this IServiceCollection services)
        {
            services.AddScoped<Aplicacao>();
        }
    }
}
