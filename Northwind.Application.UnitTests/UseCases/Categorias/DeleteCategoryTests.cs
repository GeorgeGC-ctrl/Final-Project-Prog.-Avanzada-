using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Categorias
{
    public class DeleteCategoryTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<ILogger<DeleteCategory>> _mockLogger;
        private readonly DeleteCategory _useCase;

        public DeleteCategoryTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockLogger = new Mock<ILogger<DeleteCategory>>();
            _useCase = new DeleteCategory(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoNoTieneProductosAsociados_DeberiaEliminarYRetornarExito()
        {
            // Arrange
            int categoryId = 1;
            _mockRepo.Setup(r => r.GetCategoryByIdAsync(categoryId))
                .ReturnsAsync(new Categories { CategoryId = categoryId, CategoryName = "Condimentos" });

            _mockRepo.Setup(r => r.TieneProductosAsociadosAsync(categoryId))
                .ReturnsAsync(false);

            _mockRepo.Setup(r => r.DeleteCategoryAsync(categoryId))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _useCase.EjecutarAsync(categoryId);

            // Assert
            result.IsSuccess.Should().BeTrue();
            _mockRepo.Verify(r => r.DeleteCategoryAsync(categoryId), Times.Once);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoTieneProductosAsociados_DeberiaRetornarFalloYNoEliminar()
        {
            // Arrange
            int categoryId = 2;
            _mockRepo.Setup(r => r.GetCategoryByIdAsync(categoryId))
                .ReturnsAsync(new Categories { CategoryId = categoryId, CategoryName = "Bebidas" });

            _mockRepo.Setup(r => r.TieneProductosAsociadosAsync(categoryId))
                .ReturnsAsync(true);

            // Act
            var result = await _useCase.EjecutarAsync(categoryId);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("tiene productos asociados");
            _mockRepo.Verify(r => r.DeleteCategoryAsync(It.IsAny<int>()), Times.Never);
        }
    }
}
