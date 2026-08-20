using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Productos
{
    public class CreateProductValidatorTests
    {
        private readonly CreateProductValidator _validator;

        public CreateProductValidatorTests()
        {
            _validator = new CreateProductValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new CrearProductoRequest("Chai", 1, 1, "10 boxes", 18.00m, 39, 0, 10);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeTrue();
            result.Errors.Should().BeEmpty();
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Validate_ConNombreVacio_DeberiaSerInvalido(string? nombre)
        {
            // Arrange
            var request = new CrearProductoRequest(nombre!, null, null, null, null, null, null, null);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "ProductName");
        }

        [Fact]
        public void Validate_ConNombreMayorA40Caracteres_DeberiaSerInvalido()
        {
            // Arrange
            var request = new CrearProductoRequest(new string('P', 41), null, null, null, null, null, null, null);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "ProductName");
        }

        [Fact]
        public void Validate_ConPrecioNegativo_DeberiaSerInvalido()
        {
            // Arrange
            var request = new CrearProductoRequest("Chai", null, null, null, -1.00m, null, null, null);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "UnitPrice");
        }

        [Fact]
        public void Validate_ConStockNegativo_DeberiaSerInvalido()
        {
            // Arrange
            var request = new CrearProductoRequest("Chai", null, null, null, 10.00m, -5, null, null);

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "UnitsInStock");
        }
    }
}
