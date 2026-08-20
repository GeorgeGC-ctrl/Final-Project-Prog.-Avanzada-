using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Categorias
{
    public class GetAllCategoriesTests
    {
        private readonly Mock<ICategoryRepository> _mockRepo;
        private readonly Mock<ILogger<GetAllCategories>> _mockLogger;
        private readonly GetAllCategories _useCase;

        public GetAllCategoriesTests()
        {
            _mockRepo = new Mock<ICategoryRepository>();
            _mockLogger = new Mock<ILogger<GetAllCategories>>();
            _useCase = new GetAllCategories(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_DeberiaRetornarListaDeCategoriasDto()
        {
            // Arrange
            var categorias = new List<Categories>
            {
                new Categories { CategoryId = 1, CategoryName = "Bebidas", Description = "Refrescos" },
                new Categories { CategoryId = 2, CategoryName = "Condimentos", Description = "Salsas" }
            };
            _mockRepo.Setup(r => r.GetAllCategoriesAsync())
                .ReturnsAsync(categorias);

            // Act
            var result = await _useCase.EjecutarAsync();

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().NotBeNull();
            result.Value.Should().HaveCount(2);
            result.Value!.First().CategoryName.Should().Be("Bebidas");
        }
    }
}
