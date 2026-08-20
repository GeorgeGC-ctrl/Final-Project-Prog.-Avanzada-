using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Suplidores
{
    public class SuppliersValidatorTests
    {
        private readonly SuppliersValidator _validator;

        public SuppliersValidatorTests()
        {
            _validator = new SuppliersValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new CrearSuplidorRequest("Exotic Liquids", "Charlotte Cooper", "Manager", "(171) 555-2222", "UK", "London");

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
        public void Validate_ConNombreCompaniaVacio_DeberiaSerInvalido(string? companyName)
        {
            // Arrange
            var request = new CrearSuplidorRequest(companyName!, "Charlotte", "Manager", "123", "UK", "London");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CompanyName");
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Validate_ConNombreContactoVacio_DeberiaSerInvalido(string? contactName)
        {
            // Arrange
            var request = new CrearSuplidorRequest("Exotic Liquids", contactName!, "Manager", "123", "UK", "London");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "ContactName");
        }

        [Fact]
        public void Validate_ConCiudadMayorA15Caracteres_DeberiaSerInvalido()
        {
            // Arrange
            var request = new CrearSuplidorRequest("Exotic Liquids", "Charlotte", "Manager", "123", "UK", new string('C', 16));

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "city");
        }
    }
}
