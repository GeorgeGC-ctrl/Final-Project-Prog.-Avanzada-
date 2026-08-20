using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Suplidores
{
    public class UpdateSupplierValidatorTests
    {
        private readonly UpdateSupplierValidator _validator;

        public UpdateSupplierValidatorTests()
        {
            _validator = new UpdateSupplierValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new EditarSuplidorRequest(1, "Exotic Liquids", "Charlotte Cooper", "Manager", "(171) 555-2222", "UK", "London");

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
            var request = new EditarSuplidorRequest(id, "Exotic Liquids", "Charlotte", "Manager", "123", "UK", "London");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "SupplierId");
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Validate_ConNombreCompaniaVacio_DeberiaSerInvalido(string? companyName)
        {
            // Arrange
            var request = new EditarSuplidorRequest(1, companyName!, "Charlotte", "Manager", "123", "UK", "London");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CompanyName");
        }
    }
}
