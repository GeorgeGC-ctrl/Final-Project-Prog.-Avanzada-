using FluentAssertions;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Categorias;
using Xunit;

namespace Northwind.Application.UnitTests.Validators.Categorias
{
    public class CreateCategoryValidatorTests
    {
        private readonly CreateCategoryValidator _validator;

        public CreateCategoryValidatorTests()
        {
            _validator = new CreateCategoryValidator();
        }

        [Fact]
        public void Validate_ConDatosValidos_DeberiaSerValido()
        {
            // Arrange
            var request = new CrearCategoriaRequest("Bebidas", "Refrescos y jugos");

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
            var request = new CrearCategoriaRequest(nombre!, "Descripción");

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
            var request = new CrearCategoriaRequest(new string('A', 51), "Descripción");

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "CategoryName");
        }

        [Fact]
        public void Validate_ConDescripcionMayorA200Caracteres_DeberiaSerInvalido()
        {
            // Arrange
            var request = new CrearCategoriaRequest("Bebidas", new string('D', 201));

            // Act
            var result = _validator.Validate(request);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(e => e.PropertyName == "Description");
        }
    }
}
