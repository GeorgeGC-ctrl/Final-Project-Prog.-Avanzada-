using FluentAssertions;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Domain.UnitTests.Entidades
{
    public class SuppliersTests
    {
        [Fact]
        public void Propiedades_DeberianAsignarseCorrectamente()
        {
            // Arrange & Act
            var suplidor = new Suppliers
            {
                SupplierId = 1,
                CompanyName = "Exotic Liquids",
                ContactName = "Charlotte Cooper",
                ContactTitle = "Purchasing Manager",
                Address = "49 Gilbert St.",
                City = "London",
                Region = "Greater London",
                PostalCode = "EC1 4SD",
                Country = "UK",
                Phone = "(171) 555-2222",
                Fax = null
            };

            // Assert
            suplidor.SupplierId.Should().Be(1);
            suplidor.CompanyName.Should().Be("Exotic Liquids");
            suplidor.ContactName.Should().Be("Charlotte Cooper");
            suplidor.ContactTitle.Should().Be("Purchasing Manager");
            suplidor.Address.Should().Be("49 Gilbert St.");
            suplidor.City.Should().Be("London");
            suplidor.Region.Should().Be("Greater London");
            suplidor.PostalCode.Should().Be("EC1 4SD");
            suplidor.Country.Should().Be("UK");
            suplidor.Phone.Should().Be("(171) 555-2222");
            suplidor.Fax.Should().BeNull();
            suplidor.Productos.Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void ProductosCollection_DeberiaPermitirAgregarProductos()
        {
            // Arrange
            var suplidor = new Suppliers { SupplierId = 1, CompanyName = "Exotic Liquids" };
            var producto = new Products { ProductId = 1, ProductName = "Chai", SupplierId = 1 };

            // Act
            suplidor.Productos.Add(producto);

            // Assert
            suplidor.Productos.Should().HaveCount(1).And.Contain(producto);
        }
    }
}
