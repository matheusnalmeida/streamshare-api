using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StreamShare.Infrastructure.Extensions
{
    public static class InfrastructureServiceCollectionExtension
    {
        public static void ConfigureInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            // TODO CONTEXT EF
            //services.AddDbContext<DbContext>(options =>
            //{
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //});
            //
            //services.AddScoped<DbContext>(option => {
            //    return option.GetService<DbContext>();
            //});
        }
    }
}
