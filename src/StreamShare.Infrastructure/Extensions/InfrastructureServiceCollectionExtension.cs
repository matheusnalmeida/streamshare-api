using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StreamShare.Infrastructure.Database.EFContext;

namespace StreamShare.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollectionExtension
    {
        public static void ConfigureInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StreamShareContext>(options =>
                                   options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureDB(this IServiceProvider serviceProvider) {
            using var scope = serviceProvider.CreateScope();
            
            var dbContext = scope.ServiceProvider.GetRequiredService<StreamShareContext>();
            dbContext.Database.Migrate();
        }
    }
}
