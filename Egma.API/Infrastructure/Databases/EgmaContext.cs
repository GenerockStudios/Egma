using Microsoft.EntityFrameworkCore;

namespace Egma.API.Infrastructure.Databases
{
    public class EgmaContext: DbContext
    {
        public EgmaContext(DbContextOptions<EgmaContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Base call  
            base.OnModelCreating(builder);
        }



    }
}
