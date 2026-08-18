using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.UseCases.Suplidores;

namespace Northwind.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjections).Assembly);

            services.AddTransient<CreateCategory>();
            services.AddTransient<UpdateCategory>();
            services.AddTransient<DeleteCategory>();
            services.AddTransient<GetAllCategories>();
            services.AddTransient<GetCategoryById>();

            services.AddTransient<CreateProduct>();
            services.AddTransient<UpdateProduct>();
            services.AddTransient<GetProducts>();
            services.AddTransient<GetLowStockProducts>();
            services.AddTransient<ReassignSupplier>();
            services.AddTransient<IncreasePricesByCategory>();

            services.AddTransient<CreateSupplier>();
            services.AddTransient<UpdateSupplier>();
            services.AddTransient<DeleteSupplier>();
            services.AddTransient<GetSuppliers>();
            services.AddTransient<GetSupplierById>();

            return services;
        }
    }

}
