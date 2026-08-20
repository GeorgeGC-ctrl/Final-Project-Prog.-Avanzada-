using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Productos
{
    public class UpdateProductValidatorTests
    {
        private readonly UpdateProductValidator _validator;

        public UpdateProductValidatorTests()
        {
            _validator = new UpdateProductValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new EditarProductoRequest(1, "Chai", 1, 1, "10 boxes", 18.00m, 39, 0, 10, false);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeTrue();
            result.Errors.Should().BeEmpty();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Validate_ConIdInvalido_DeberiaSerInvalido(int id)
        {
            // Arrange
            var request = new EditarProductoRequest(id, "Chai", null, null, null, null, null, null, null, false);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "ProductId");
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Validate_ConNombreVacio_DeberiaSerInvalido(string? nombre)
        {
            // Arrange
            var request = new EditarProductoRequest(1, nombre!, null, null, null, null, null, null, null, false);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "ProductName");
        }
    }
}
