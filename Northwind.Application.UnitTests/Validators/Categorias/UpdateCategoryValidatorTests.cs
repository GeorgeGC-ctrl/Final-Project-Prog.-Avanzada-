using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Categorias;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Categorias
{
    public class UpdateCategoryValidatorTests
    {
        private readonly UpdateCategoryValidator _validator;

        public UpdateCategoryValidatorTests()
        {
            _validator = new UpdateCategoryValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new EditarCategoriaRequest(1, "Bebidas", "Refrescos y jugos");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeTrue();
            result.Errors.Should().BeEmpty();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Validate_ConIdMenorOIgualACero_DeberiaSerInvalido(int id)
        {
            // Arrange
            var request = new EditarCategoriaRequest(id, "Bebidas", "Descripción");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CategoryId");
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData(null)]
        public void Validate_ConNombreVacio_DeberiaSerInvalido(string? nombre)
        {
            // Arrange
            var request = new EditarCategoriaRequest(1, nombre!, "Descripción");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CategoryName");
        }

        [Fact]
        public void Validate_ConNombreMayorA50Caracteres_DeberiaSerInvalido()
        {
            // Arrange
            var request = new EditarCategoriaRequest(1, new string('A', 51), "Descripción");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CategoryName");
        }
    }
}
