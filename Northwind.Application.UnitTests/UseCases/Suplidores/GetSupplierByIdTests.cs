using FluentAssertions;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Application.UseCases.Suplidores;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Application.UnitTests.UseCases.Suplidores
{
    public class GetSupplierByIdTests
    {
        private readonly Mock<ISupplierRepository> _mockRepo;
        private readonly Mock<ILogger<GetSupplierById>> _mockLogger;
        private readonly GetSupplierById _useCase;

        public GetSupplierByIdTests()
        {
            _mockRepo = new Mock<ISupplierRepository>();
            _mockLogger = new Mock<ILogger<GetSupplierById>>();
            _useCase = new GetSupplierById(_mockRepo.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task EjecutarAsync_CuandoExiste_DeberiaRetornarSuplidorDto()
        {
            // Arrange
            var suplidor = new Suppliers
            {
                SupplierId = 1,
                CompanyName = "Exotic Liquids",
                ContactName = "Charlotte Cooper",
                ContactTitle = "Purchasing Manager",
                Phone = "(171) 555-2222",
                Country = "UK",
                City = "London"
            };
            _mockRepo.Setup(r => r.ObtenerPorIdAsync(1))
                .ReturnsAsync(suplidor);

            // Act
            var result = await _useCase.EjecutarAsync(1);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.Value.Should().NotBeNull();
            result.Value!.SupplierId.Should().Be(1);
            result.Value.CompanyName.Should().Be("Exotic Liquids");
        }

        [Fact]
        public async Task EjecutarAsync_CuandoNoExiste_DeberiaRetornarFallo()
        {
            // Arrange
            _mockRepo.Setup(r => r.ObtenerPorIdAsync(99))
                .ReturnsAsync((Suppliers?)null);

            // Act
            var result = await _useCase.EjecutarAsync(99);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.Error.Should().Contain("No se encontró el proveedor con ID 99.");
        }
    }
}
