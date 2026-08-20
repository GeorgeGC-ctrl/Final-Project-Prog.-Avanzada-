using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.Validators.Productos;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Productos
{
    public class IncreasePricesByCategoryTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<ILogger<IncreasePricesByCategory>> _mockLogger;
        private readonly IncreasePricesByCategory _useCase;

        public IncreasePricesByCategoryTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockLogger = new Mock<ILogger<IncreasePricesByCategory>>();
            _useCase = new IncreasePricesByCategory(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConPorcentajeValido_DeberiaIncrementarPreciosYRetornarExito()
        {
            // Arrange
            var request = new IncrementarPrecioCategoriaRequest(1, 10.5m);
            _mockRepo.Setup(r => r.IncrementarPreciosPorCategoriaAsync(1, 10.5m))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            _mockRepo.Verify(r => r.IncrementarPreciosPorCategoriaAsync(1, 10.5m), Times.Once);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(-10.5)]
        public async Task EjecutarAsync_ConPorcentajeInvalido_DeberiaRetornarFalloYNoLlamarRepo(decimal porcentaje)
        {
            // Arrange
            var request = new IncrementarPrecioCategoriaRequest(1, porcentaje);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("El porcentaje debe ser mayor a 0.");
            _mockRepo.Verify(r => r.IncrementarPreciosPorCategoriaAsync(It.IsAny<int>(), It.IsAny<decimal>()), Times.Never);
        }
    }
}
