using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.DTOs
{
   
    public record ProductoDto(
        int ProductId,
        string ProductName,
        int? SupplierId,
        string? SupplierName,
        int? CategoryId,
        string? CategoryName,
        string? QuantityPerUnit,
        decimal? UnitPrice,
        short? UnitsInStock,
        short? UnitsOnOrder,
        short? ReorderLevel,
        bool Discontinued);
    public record CrearProductoRequest(
        string ProductName, int? SupplierId, int? CategoryId, string? QuantityPerUnit,
        decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel);
    public record EditarProductoRequest(
        int ProductId, string ProductName, int? SupplierId, int? CategoryId, string? QuantityPerUnit,
        decimal? UnitPrice, short? UnitsInStock, short? UnitsOnOrder, short? ReorderLevel, bool Discontinued);

}
