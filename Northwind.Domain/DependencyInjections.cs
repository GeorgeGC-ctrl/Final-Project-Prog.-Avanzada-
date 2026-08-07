using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDomain(this IServiceCollection services, IConfiguration configuration)
        {
        
            return services;
        }
    }
}
