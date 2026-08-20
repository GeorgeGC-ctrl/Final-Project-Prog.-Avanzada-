using FluentAssertions;
using Northwind.Domain.Entidades;
using Xunit;

namespace Northwind.Domain.UnitTests.Entidades
{
    public class ProductsTests
    {
        [Fact]
        public void Descontinuar_DeberiaCambiarDiscontinuedATrue()
        {
            // Arrange
            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Chai",
                Discontinued = false
            };

            // Act
            producto.Descontinuar();

            // Assert
            producto.Discontinued.Should().BeTrue();
        }

        [Fact]
        public void Reactivar_DeberiaCambiarDiscontinuedAFalse()
        {
            // Arrange
            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Chai",
                Discontinued = true
            };

            // Act
            producto.Reactivar();

            // Assert
            producto.Discontinued.Should().BeFalse();
        }

        [Theory]
        [InlineData(10.00, 10, 11.00)]
        [InlineData(100.00, 15, 115.00)]
        [InlineData(19.99, 5, 20.99)]
        public void AplicarIncrementoPrecio_ConPorcentajeValido_DeberiaIncrementarPrecioCorrectamente(
            decimal precioInicial, decimal porcentaje, decimal precioEsperado)
        {
            // Arrange
            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Producto Test",
                UnitPrice = precioInicial
            };

            // Act
            producto.AplicarIncrementoPrecio(porcentaje);

            // Assert
            producto.UnitPrice.Should().Be(precioEsperado);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(-10.5)]
        public void AplicarIncrementoPrecio_ConPorcentajeInvalido_DeberiaLanzarArgumentException(decimal porcentaje)
        {
            // Arrange
            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Producto Test",
                UnitPrice = 10.00m
            };

            // Act
            var accion = () => producto.AplicarIncrementoPrecio(porcentaje);

            // Assert
            accion.Should().Throw<ArgumentException>()
                .WithMessage("El porcentaje debe ser mayor a 0.");
        }

        [Fact]
        public void AplicarIncrementoPrecio_CuandoUnitPriceEsNull_NoDeberiaModificarNiLanzarExcepcion()
        {
            // Arrange
            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Producto Test",
                UnitPrice = null
            };

            // Act
            var accion = () => producto.AplicarIncrementoPrecio(10);

            // Assert
            accion.Should().NotThrow();
            producto.UnitPrice.Should().BeNull();
        }

        [Fact]
        public void Propiedades_DeberianAsignarseCorrectamente()
        {
            // Arrange & Act
            var categoria = new Categories { CategoryId = 2, CategoryName = "Bebidas" };
            var suplidor = new Suppliers { SupplierId = 3, CompanyName = "Proveedor ABC" };

            var producto = new Products
            {
                ProductId = 1,
                ProductName = "Chai",
                SupplierId = 3,
                CategoryId = 2,
                QuantityPerUnit = "10 boxes x 20 bags",
                UnitPrice = 18.00m,
                UnitsInStock = 39,
                UnitsOnOrder = 0,
                ReorderLevel = 10,
                Discontinued = false,
                Categoria = categoria,
                Suplidor = suplidor
            };

            // Assert
            producto.ProductId.Should().Be(1);
            producto.ProductName.Should().Be("Chai");
            producto.SupplierId.Should().Be(3);
            producto.CategoryId.Should().Be(2);
            producto.QuantityPerUnit.Should().Be("10 boxes x 20 bags");
            producto.UnitPrice.Should().Be(18.00m);
            producto.UnitsInStock.Should().Be(39);
            producto.UnitsOnOrder.Should().Be(0);
            producto.ReorderLevel.Should().Be(10);
            producto.Discontinued.Should().BeFalse();
            producto.Categoria.Should().Be(categoria);
            producto.Suplidor.Should().Be(suplidor);
        }
    }
}
