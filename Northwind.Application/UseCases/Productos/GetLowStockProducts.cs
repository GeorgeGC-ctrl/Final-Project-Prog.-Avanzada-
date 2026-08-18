using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Productos
{
    public class GetLowStockProducts
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<GetLowStockProducts> _logger;

        public GetLowStockProducts(IProductRepository productRepository, ILogger<GetLowStockProducts> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<ProductoDto>>> EjecutarAsync()
        {
            _logger.LogInformation("Consultando productos bajo el nivel de reorden");

            var productos = await _productRepository.ObtenerBajoNivelReordenAsync();
            var dtos = productos.Select(p => new ProductoDto(
                p.ProductId, p.ProductName, p.SupplierId, p.Suplidor?.CompanyName, p.CategoryId, p.Categoria?.CategoryName,
                p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued));

            return Result<IEnumerable<ProductoDto>>.Success(dtos);
        }
    }
}
