using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.Validators.Productos;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Productos
{
    public class ReassignSupplierTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<ILogger<ReassignSupplier>> _mockLogger;
        private readonly ReassignSupplier _useCase;

        public ReassignSupplierTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockLogger = new Mock<ILogger<ReassignSupplier>>();
            _useCase = new ReassignSupplier(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConProveedoresDistintos_DeberiaReasignarYRetornarExito()
        {
            // Arrange
            var request = new ReasignarSuplidorRequest(1, 2);
            _mockRepo.Setup(r => r.ReasignarSuplidorAsync(1, 2))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            _mockRepo.Verify(r => r.ReasignarSuplidorAsync(1, 2), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoOrigenYDestinoSonIguales_DeberiaRetornarFalloYNoLlamarRepo()
        {
            // Arrange
            var request = new ReasignarSuplidorRequest(5, 5);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Be("El proveedor de origen y destino no pueden ser el mismo.");
            _mockRepo.Verify(r => r.ReasignarSuplidorAsync(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }
    }
}
