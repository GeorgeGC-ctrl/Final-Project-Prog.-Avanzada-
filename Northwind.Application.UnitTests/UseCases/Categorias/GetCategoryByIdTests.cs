using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Categorias
{
    public class GetCategoryByIdTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<ILogger<GetCategoryById>> _mockLogger;
        private readonly GetCategoryById _useCase;

        public GetCategoryByIdTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockLogger = new Mock<ILogger<GetCategoryById>>();
            _useCase = new GetCategoryById(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoExiste_DeberiaRetornarCategoriaDto()
        {
            // Arrange
            var categoria = new Categories { CategoryId = 1, CategoryName = "Bebidas", Description = "Refrescos" };
            _mockRepo.Setup(r => r.GetCategoryByIdAsync(1))
                .ReturnsAsync(categoria);

            // Act
            var result = await _useCase.EjecutarAsync(1);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().NotBeNull();
            result.Value!.CategoryId.Should().Be(1);
            result.Value.CategoryName.Should().Be("Bebidas");
        }

        [Fact]
        public async Task EjecutarAsync_CuandoNoExiste_DeberiaRetornarFallo()
        {
            // Arrange
            _mockRepo.Setup(r => r.GetCategoryByIdAsync(99))
                .ReturnsAsync((Categories?)null);

            // Act
            var result = await _useCase.EjecutarAsync(99);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("No se encontró la categoría con ID 99.");
        }
    }
}
