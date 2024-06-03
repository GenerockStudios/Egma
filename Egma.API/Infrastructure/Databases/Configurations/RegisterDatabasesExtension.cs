using Microsoft.EntityFrameworkCore;

namespace Egma.API.Infrastructure.Databases.Configurations
{
    public static class RegisterDatabasesExtension
    {
        public static IServiceCollection AddDatabaseEgmaContext(this IServiceCollection services, IConfiguration configuration)
        {
            string cs = configuration.GetConnectionString("egma_context_postgresql")!;
            services.AddDbContext<EgmaContext>(options =>
            {
                options.UseNpgsql(cs, c => c.MigrationsAssembly("Egma.API"));
            }
           );
            return services;
        }
    }
}
