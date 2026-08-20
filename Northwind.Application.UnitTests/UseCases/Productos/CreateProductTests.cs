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
    public class CreateProductTests
    {
        private readonly Mock<IProductRepository> _mockRepo;
        private readonly Mock<IValidator<CrearProductoRequest>> _mockValidator;
        private readonly Mock<ILogger<CreateProduct>> _mockLogger;
        private readonly CreateProduct _useCase;

        public CreateProductTests()
        {
            _mockRepo = new Mock<IProductRepository>();
            _mockValidator = new Mock<IValidator<CrearProductoRequest>>();
            _mockLogger = new Mock<ILogger<CreateProduct>>();
            _useCase = new CreateProduct(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConDatosValidos_DeberiaCrearProductoYRetornarId()
        {
            // Arrange
            var request = new CrearProductoRequest("Chai", 1, 1, "10 boxes", 18.00m, 39, 0, 10);
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.CrearAsync(It.IsAny<Products>()))
                .Callback<Products>(p => p.ProductId = 100)
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().Be(100);
            _mockRepo.Verify(r => r.CrearAsync(It.Is<Products>(p => p.ProductName == "Chai")), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoValidacionFalla_DeberiaRetornarFalloYNoCrear()
        {
            // Arrange
            var request = new CrearProductoRequest("", null, null, null, -5, null, null, null);
            var validationFailures = new List<ValidationFailure>
            {
                new ValidationFailure("ProductName", "El nombre del producto es obligatorio.")
            };
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("El nombre del producto es obligatorio.");
            _mockRepo.Verify(r => r.CrearAsync(It.IsAny<Products>()), Times.Never);
        }
    }
}
