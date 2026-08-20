using FluentAssertions;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Domain.UnitTests.Entidades
{
    public class CategoriesTests
    {
        [Fact]
        public void Propiedades_DeberianAsignarseCorrectamente()
        {
            // Arrange & Act
            var categoria = new Categories
            {
                CategoryId = 1,
                CategoryName = "Bebidas",
                Description = "Refrescos, cafés, tés",
                Picture = new byte[] { 1, 2, 3 }
            };

            // Assert
            categoria.CategoryId.Should().Be(1);
            categoria.CategoryName.Should().Be("Bebidas");
            categoria.Description.Should().Be("Refrescos, cafés, tés");
            categoria.Picture.Should().BeEquivalentTo(new byte[] { 1, 2, 3 });
            categoria.Products.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void ProductsCollection_DeberiaPermitirAgregarProductos()
        {
            // Arrange
            var categoria = new Categories { CategoryId = 1, CategoryName = "Bebidas" };
            var producto = new Products { ProductId = 1, ProductName = "Chai", CategoryId = 1 };

            // Act
            categoria.Products.Add(producto);

            // Assert
            categoria.Products.Should().HaveCount(1).And.Contain(producto);
        }
    }
}
