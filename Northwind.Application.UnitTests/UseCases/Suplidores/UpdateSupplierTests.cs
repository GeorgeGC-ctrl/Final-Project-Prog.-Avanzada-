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
    public class UpdateSupplierTests
    {
        private readonly Mock<ISupplierRepository> _mockRepo;
        private readonly Mock<IValidator<EditarSuplidorRequest>> _mockValidator;
        private readonly Mock<ILogger<UpdateSupplier>> _mockLogger;
        private readonly UpdateSupplier _useCase;

        public UpdateSupplierTests()
        {
            _mockRepo = new Mock<ISupplierRepository>();
            _mockValidator = new Mock<IValidator<EditarSuplidorRequest>>();
            _mockLogger = new Mock<ILogger<UpdateSupplier>>();
            _useCase = new UpdateSupplier(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConDatosValidos_DeberiaActualizarYRetornarExito()
        {
            // Arrange
            var request = new EditarSuplidorRequest(1, "Exotic Liquids Ltd", "Charlotte Cooper", "Director", "(171) 555-2222", "UK", "London");
            var suplidorExistente = new Suppliers { SupplierId = 1, CompanyName = "Exotic Liquids" };

            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.ObtenerPorIdAsync(1))
                .ReturnsAsync(suplidorExistente);

            _mockRepo.Setup(r => r.ActualizarAsync(It.IsAny<Suppliers>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            suplidorExistente.CompanyName.Should().Be("Exotic Liquids Ltd");
            suplidorExistente.ContactTitle.Should().Be("Director");
            _mockRepo.Verify(r => r.ActualizarAsync(suplidorExistente), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoValidacionFalla_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarSuplidorRequest(1, "", "", null, null, null, "");
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
            _mockRepo.Verify(r => r.ActualizarAsync(It.IsAny<Suppliers>()), Times.Never);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoSuplidorNoExiste_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarSuplidorRequest(999, "No Existe", "Contacto", null, null, null, "Ciudad");
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.ObtenerPorIdAsync(999))
                .ReturnsAsync((Suppliers?)null);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("No se encontró el proveedor con ID 999.");
            _mockRepo.Verify(r => r.ActualizarAsync(It.IsAny<Suppliers>()), Times.Never);
        }
    }
}
