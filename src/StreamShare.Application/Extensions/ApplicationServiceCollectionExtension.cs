using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StreamShare.Application.Queries;
using System.Reflection;

namespace StreamShare.Application.Extensions
{
    public static class ApplicationServiceCollectionExtension
    {
        public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
