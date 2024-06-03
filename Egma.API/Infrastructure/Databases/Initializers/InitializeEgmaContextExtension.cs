using Microsoft.EntityFrameworkCore;

namespace Egma.API.Infrastructure.Databases.Initializers
{
    public static class InitializeEgmaContextExtension
    {
        /// <summary>
        /// This extension Initialize Erotion database
        /// </summary>
        /// <param name="serviceProvider">Service provider of scope, of your application</param>
        /// <returns></returns>
        public async static Task<IServiceProvider> InitializeEgmaContext(this IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<EgmaContext>();
            await context.Database.MigrateAsync();
            return serviceProvider;
        }
    }
}
