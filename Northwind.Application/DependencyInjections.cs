using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.UseCases.Categorias;

namespace Northwind.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
          services.AddValidatorsFromAssembly(typeof(DependencyInjections).Assembly);

            services.AddTransient<CreateCategory>();
            services.AddTransient<DeleteCategory>();

            return services;
        }
    }
}
