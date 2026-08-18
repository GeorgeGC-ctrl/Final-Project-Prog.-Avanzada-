using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Validators.Categorias;
using Northwind.Application.Validators.Productos;
using Northwind.Application.Validators.Suplidores;
using Northwind.Infrastructure;
using Northwind.Infrastructure.Persistence.Repositorios;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("Northwind")));

            services.AddScoped<ICategoryRepository, CategoriaRepositorio>();
            services.AddScoped<IProductRepository, ProductoRepositorio>();
            services.AddScoped<ISupplierRepository, SuplidorRepositorio>();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

            return services;
        }
    }
}
