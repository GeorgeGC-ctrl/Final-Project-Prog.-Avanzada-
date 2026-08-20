using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Productos
{
    public class GetLowStockProductsTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<ILogger<GetLowStockProducts>> _mockLogger;
        private readonly GetLowStockProducts _useCase;

        public GetLowStockProductsTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockLogger = new Mock<ILogger<GetLowStockProducts>>();
            _useCase = new GetLowStockProducts(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_DeberiaRetornarProductosBajoNivelReorden()
        {
            // Arrange
            var productos = new List<Products>
            {
                new Products { ProductId = 1, ProductName = "Chai", UnitsInStock = 5, ReorderLevel = 10 }
            };
            _mockRepo.Setup(r => r.ObtenerBajoNivelReordenAsync())
                .ReturnsAsync(productos);

            // Act
            var result = await _useCase.EjecutarAsync();

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().HaveCount(1);
            result.Value!.First().ProductName.Should().Be("Chai");
            _mockRepo.Verify(r => r.ObtenerBajoNivelReordenAsync(), Times.Once);
        }
    }
}
