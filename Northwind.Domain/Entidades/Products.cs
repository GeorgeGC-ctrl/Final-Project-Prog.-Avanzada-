using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Domain.Entidades
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        
        public Categories? Categoria { get; set; }
        public Suppliers? Suplidor { get; set; }
        
        public void Descontinuar() => Discontinued = true;
        public void Reactivar() => Discontinued = false;

        public void AplicarIncrementoPrecio(decimal porcentaje)
        {
            if (porcentaje <= 0) throw new ArgumentException("El porcentaje debe ser mayor a 0.");
            if (UnitPrice.HasValue)
            {
                UnitPrice = Math.Round(UnitPrice.Value * (1 + (porcentaje / 100)), 2);
            }
        }
    }

}