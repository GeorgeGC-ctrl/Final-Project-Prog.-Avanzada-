using FluentAssertions;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.UseCases.Suplidores;
using Xunit;

namespace Northwind.Application.UnitTests.DependencyInjection
{
    public class DependencyInjectionsTests
    {
        [Fact]
        public void AddApplication_DeberiaRegistrarCasosDeUsoYValidadores()
        {
            // Arrange
            var services = new ServiceCollection();
            var configuration = new Mock<IConfiguration>().Object;

            // Act
            services.AddApplication(configuration);
            var serviceProvider = services.BuildServiceProvider();

            // Assert - Use Cases Categorias
            services.Should().Contain(s => s.ServiceType == typeof(CreateCategory));
            services.Should().Contain(s => s.ServiceType == typeof(UpdateCategory));
            services.Should().Contain(s => s.ServiceType == typeof(DeleteCategory));
            services.Should().Contain(s => s.ServiceType == typeof(GetAllCategories));
            services.Should().Contain(s => s.ServiceType == typeof(GetCategoryById));

            // Assert - Use Cases Productos
            services.Should().Contain(s => s.ServiceType == typeof(CreateProduct));
            services.Should().Contain(s => s.ServiceType == typeof(UpdateProduct));
            services.Should().Contain(s => s.ServiceType == typeof(GetProducts));
            services.Should().Contain(s => s.ServiceType == typeof(GetLowStockProducts));
            services.Should().Contain(s => s.ServiceType == typeof(ReassignSupplier));
            services.Should().Contain(s => s.ServiceType == typeof(IncreasePricesByCategory));

            // Assert - Use Cases Suplidores
            services.Should().Contain(s => s.ServiceType == typeof(CreateSupplier));
            services.Should().Contain(s => s.ServiceType == typeof(UpdateSupplier));
            services.Should().Contain(s => s.ServiceType == typeof(DeleteSupplier));
            services.Should().Contain(s => s.ServiceType == typeof(GetSuppliers));
            services.Should().Contain(s => s.ServiceType == typeof(GetSupplierById));

            // Assert - Validators
            serviceProvider.GetService<IValidator<CrearCategoriaRequest>>().Should().NotBeNull();
            serviceProvider.GetService<IValidator<EditarCategoriaRequest>>().Should().NotBeNull();
            serviceProvider.GetService<IValidator<CrearProductoRequest>>().Should().NotBeNull();
            serviceProvider.GetService<IValidator<EditarProductoRequest>>().Should().NotBeNull();
            serviceProvider.GetService<IValidator<CrearSuplidorRequest>>().Should().NotBeNull();
            serviceProvider.GetService<IValidator<EditarSuplidorRequest>>().Should().NotBeNull();
        }
    }
}
