using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Suplidores;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Suplidores
{
    public class CreateSupplierTests
    {
        private readonly Mock<ISupplierRepository> _mockRepo;
        private readonly Mock<IValidator<CrearSuplidorRequest>> _mockValidator;
        private readonly Mock<ILogger<CreateSupplier>> _mockLogger;
        private readonly CreateSupplier _useCase;

        public CreateSupplierTests()
        {
            _mockRepo = new Mock<ISupplierRepository>();
            _mockValidator = new Mock<IValidator<CrearSuplidorRequest>>();
            _mockLogger = new Mock<ILogger<CreateSupplier>>();
            _useCase = new CreateSupplier(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConDatosValidos_DeberiaCrearProveedorYRetornarId()
        {
            // Arrange
            var request = new CrearSuplidorRequest("Exotic Liquids", "Charlotte Cooper", "Purchasing Manager", "(171) 555-2222", "UK", "London");
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.CrearAsync(It.IsAny<Suppliers>()))
                .Callback<Suppliers>(s => s.SupplierId = 15)
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().Be(15);
            _mockRepo.Verify(r => r.CrearAsync(It.Is<Suppliers>(s => s.CompanyName == "Exotic Liquids")), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoValidacionFalla_DeberiaRetornarFalloYNoCrear()
        {
            // Arrange
            var request = new CrearSuplidorRequest("", "", null, null, null, "");
            var validationFailures = new List<ValidationFailure>
            {
                new ValidationFailure("CompanyName", "El nombre es obligatorio")
            };
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("El nombre es obligatorio");
            _mockRepo.Verify(r => r.CrearAsync(It.IsAny<Suppliers>()), Times.Never);
        }
    }
}
