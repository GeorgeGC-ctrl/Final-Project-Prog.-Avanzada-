using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Productos
{
    public class GetProductsTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<ILogger<GetProducts>> _mockLogger;
        private readonly GetProducts _useCase;

        public GetProductsTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockLogger = new Mock<ILogger<GetProducts>>();
            _useCase = new GetProducts(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_SinFiltros_DeberiaRetornarTodosLosProductos()
        {
            // Arrange
            var productos = new List<Products>
            {
                new Products { ProductId = 1, ProductName = "Chai", UnitPrice = 18.00m },
                new Products { ProductId = 2, ProductName = "Chang", UnitPrice = 19.00m }
            };
            _mockRepo.Setup(r => r.ObtenerFiltradosAsync(null, null))
                .ReturnsAsync(productos);

            // Act
            var result = await _useCase.EjecutarAsync();

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().HaveCount(2);
            result.Value!.First().ProductName.Should().Be("Chai");
        }

        [Fact]
        public async Task EjecutarAsync_ConFiltros_DeberiaLlamarRepoConParametros()
        {
            // Arrange
            var productos = new List<Products>
            {
                new Products { ProductId = 1, ProductName = "Chai", CategoryId = 1, SupplierId = 2 }
            };
            _mockRepo.Setup(r => r.ObtenerFiltradosAsync(1, 2))
                .ReturnsAsync(productos);

            // Act
            var result = await _useCase.EjecutarAsync(1, 2);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().HaveCount(1);
            _mockRepo.Verify(r => r.ObtenerFiltradosAsync(1, 2), Times.Once);
        }
    }
}
