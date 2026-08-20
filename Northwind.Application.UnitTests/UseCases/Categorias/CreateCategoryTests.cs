using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Categorias
{
    public class CreateCategoryTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<IValidator<CrearCategoriaRequest>> _mockValidator;
        private readonly Mock<ILogger<CreateCategory>> _mockLogger;
        private readonly CreateCategory _useCase;

        public CreateCategoryTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockValidator = new Mock<IValidator<CrearCategoriaRequest>>();
            _mockLogger = new Mock<ILogger<CreateCategory>>();
            _useCase = new CreateCategory(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecurarAsync_ConDatosValidos_DeberiaCrearCategoriaYRetornarExito()
        {
            // Arrange
            var request = new CrearCategoriaRequest("Bebidas", "Refrescos y jugos");
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.CreateCategoryAsync(It.IsAny<Categories>()))
                .Callback<Categories>(c => c.CategoryId = 10)
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecurarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().Be(10);
            _mockRepo.Verify(r => r.CreateCategoryAsync(It.Is<Categories>(c =>
                c.CategoryName == "Bebidas" && c.Description == "Refrescos y jugos")), Times.Once);
        }

        [Fact]
        public async Task EjecurarAsync_CuandoValidacionFalla_DeberiaRetornarFalloYNoLlamarRepositorio()
        {
            // Arrange
            var request = new CrearCategoriaRequest("", null);
            var validationFailures = new List<ValidationFailure>
            {
                new ValidationFailure("CategoryName", "El nombre de la categoría es obligatorio.")
            };
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            // Act
            var result = await _useCase.EjecurarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("El nombre de la categoría es obligatorio.");
            _mockRepo.Verify(r => r.CreateCategoryAsync(It.IsAny<Categories>()), Times.Never);
        }
    }
}
