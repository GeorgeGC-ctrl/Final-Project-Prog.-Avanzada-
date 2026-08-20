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
    public class UpdateCategoryTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<IValidator<EditarCategoriaRequest>> _mockValidator;
        private readonly Mock<ILogger<UpdateCategory>> _mockLogger;
        private readonly UpdateCategory _useCase;

        public UpdateCategoryTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockValidator = new Mock<IValidator<EditarCategoriaRequest>>();
            _mockLogger = new Mock<ILogger<UpdateCategory>>();
            _useCase = new UpdateCategory(_mockRepo.Object, _mockValidator.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_ConDatosValidos_DeberiaActualizarYRetornarExito()
        {
            // Arrange
            var request = new EditarCategoriaRequest(1, "Bebidas Editadas", "Nueva descripción");
            var categoriaExistente = new Categories { CategoryId = 1, CategoryName = "Bebidas", Description = "Vieja descripción" };

            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.GetCategoryByIdAsync(1))
                .ReturnsAsync(categoriaExistente);

            _mockRepo.Setup(r => r.UpdateCategoryAsync(It.IsAny<Categories>()))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeTrue();
            categoriaExistente.CategoryName.Should().Be("Bebidas Editadas");
            categoriaExistente.Description.Should().Be("Nueva descripción");
            _mockRepo.Verify(r => r.UpdateCategoryAsync(categoriaExistente), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoValidacionFalla_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarCategoriaRequest(1, "", null);
            var validationFailures = new List<ValidationFailure>
            {
                new ValidationFailure("CategoryName", "El nombre es obligatorio")
            };
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult(validationFailures));

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("El nombre es obligatorio");
            _mockRepo.Verify(r => r.UpdateCategoryAsync(It.IsAny<Categories>()), Times.Never);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoCategoriaNoExiste_DeberiaRetornarFallo()
        {
            // Arrange
            var request = new EditarCategoriaRequest(99, "Nombre", "Desc");
            _mockValidator.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ValidationResult());

            _mockRepo.Setup(r => r.GetCategoryByIdAsync(99))
                .ReturnsAsync((Categories?)null);

            // Act
            var result = await _useCase.EjecutarAsync(request);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("No se encontró la categoría con ID 99.");
            _mockRepo.Verify(r => r.UpdateCategoryAsync(It.IsAny<Categories>()), Times.Never);
        }
    }
}
