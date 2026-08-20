using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Suplidores;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Suplidores
{
    public class GetSuppliersTests
    {
        private readonly Mock<ISupplierRepository> _mockRepo;
        private readonly Mock<ILogger<GetSuppliers>> _mockLogger;
        private readonly GetSuppliers _useCase;

        public GetSuppliersTests()
        {
            _mockRepo = new Mock<ISupplierRepository>();
            _mockLogger = new Mock<ILogger<GetSuppliers>>();
            _useCase = new GetSuppliers(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_DeberiaRetornarListaDeProveedoresDto()
        {
            // Arrange
            var suplidores = new List<Suppliers>
            {
                new Suppliers { SupplierId = 1, CompanyName = "Exotic Liquids", ContactName = "Charlotte", City = "London" },
                new Suppliers { SupplierId = 2, CompanyName = "New Orleans Cajun Delights", ContactName = "Shelley", City = "New Orleans" }
            };
            _mockRepo.Setup(r => r.ObtenerTodosAsync())
                .ReturnsAsync(suplidores);

            // Act
            var result = await _useCase.EjecutarAsync();

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().HaveCount(2);
            result.Value!.First().CompanyName.Should().Be("Exotic Liquids");
        }
    }
}
