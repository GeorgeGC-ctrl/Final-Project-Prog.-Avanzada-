using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Suplidores;
using Northwind.Application.Validators.Suplidores;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Suplidores
{
    public class DeleteSupplierTests
    {
        private readonly Mock<ISupplierRepository> _mockRepo;
        private readonly Mock<ILogger<DeleteSupplier>> _mockLogger;
        private readonly DeleteSupplier _useCase;

        public DeleteSupplierTests()
        {
            _mockRepo = new Mock<ISupplierRepository>();
            _mockLogger = new Mock<ILogger<DeleteSupplier>>();
            _useCase = new DeleteSupplier(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoNoTieneProductosAsociados_DeberiaEliminarYRetornarExito()
        {
            // Arrange
            int supplierId = 1;
            _mockRepo.Setup(r => r.TieneProductosAsociadosAsync(supplierId))
                .ReturnsAsync(false);

            _mockRepo.Setup(r => r.EliminarAsync(supplierId))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(supplierId);

            // Assert
            result.IsSuccess.Should().BeTrue();
            _mockRepo.Verify(r => r.EliminarAsync(supplierId), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoTieneProductosAsociados_DeberiaRetornarFalloYNoEliminar()
        {
            // Arrange
            int supplierId = 2;
            _mockRepo.Setup(r => r.TieneProductosAsociadosAsync(supplierId))
                .ReturnsAsync(true);

            // Act
            var result = await _useCase.EjecutarAsync(supplierId);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("tiene productos asociados");
            _mockRepo.Verify(r => r.EliminarAsync(It.IsAny<int>()), Times.Never);
        }
    }
}
