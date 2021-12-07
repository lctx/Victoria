using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Context;

namespace Persistence
{
    public static class DependencyInjection
    {
        /// <summary>
        /// solo utilizar mysql, 1 base para desarrollo y otra para produccion en vez de sqlite y mysql
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {

            //probar si esto no causa problemas ya que no aparece el metodo 
            string cadenaConexion= env.IsDevelopment() ?
                    configuration.GetConnectionString("ProductionConnection") :
                    configuration.GetConnectionString("DevelopmentConnection");
            var serverVersion = new MariaDbServerVersion(new Version(10, 3, 30));
            services.AddDbContext<ProduccionDbContext>(
                    dbContextOptions => dbContextOptions
                    .UseMySql(cadenaConexion,
                         serverVersion, b => b.MigrationsAssembly(typeof(ProduccionDbContext).Assembly.FullName))
                        .EnableSensitiveDataLogging() // <-- These two calls are optional but help
                        .EnableDetailedErrors()       // <-- with debugging (remove for production).
                        );
            services.AddScoped<ProduccionDbContext>(provider => provider.GetService<ProduccionDbContext>());
        }
    }
}