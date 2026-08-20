using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Productos
{
    public class UpdateProductTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<IValidator<EditarProductoRequest>> _mockValidator;
        private readonly Mock<ILogger<UpdateProduct>> _mockLogger;
        private readonly UpdateProduct _useCase;

        public UpdateProductTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockValidator = new Mock<IValidator<EditarProductoRequest>>();
            _mockLogger = new Mock<ILogger<UpdateProduct>>();
            _useCase = new UpdateProduct(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConDatosValidos_DeberiaActualizarYRetornarExito()
        {
            // Arrange
            var request = new EditarProductoRequest(1, "Chai Modificado", 1, 1, "10 boxes", 20.00m, 40, 5, 10, false);
            var productoExistente = new Products { ProductId = 1, ProductName = "Chai", UnitPrice = 18.00m };

            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.ObtenerPorIdAsync(1))
                .ReturnsAsync(productoExistente);

            _mockRepo.Setup(r => r.ActualizarAsync(It.IsAny<Products>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            productoExistente.ProductName.Should().Be("Chai Modificado");
            productoExistente.UnitPrice.Should().Be(20.00m);
            _mockRepo.Verify(r => r.ActualizarAsync(productoExistente), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoValidacionFalla_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarProductoRequest(1, "", null, null, null, null, null, null, null, false);
            var validationFailures = new List<ValidationFailure>
            {
                new ValidationFailure("ProductName", "El nombre es obligatorio")
            };
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("El nombre es obligatorio");
            _mockRepo.Verify(r => r.ActualizarAsync(It.IsAny<Products>()), Times.Never);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoProductoNoExiste_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarProductoRequest(999, "Producto Fantasma", null, null, null, null, null, null, null, false);
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.ObtenerPorIdAsync(999))
                .ReturnsAsync((Products?)null);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("No se encontró el producto con ID 999.");
            _mockRepo.Verify(r => r.ActualizarAsync(It.IsAny<Products>()), Times.Never);
        }
    }
}
