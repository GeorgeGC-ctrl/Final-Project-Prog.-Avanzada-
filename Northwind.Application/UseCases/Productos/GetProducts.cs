using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Productos
{
    public class GetProducts
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<GetProducts> _logger;

        public GetProducts(IProductRepository productRepository, ILogger<GetProducts> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<ProductoDto>>> EjecutarAsync(int? categoriaId = null, int? suplidorId = null)
        {
            _logger.LogInformation("Consultando productos. Categoria: {CategoriaId}, Suplidor: {SuplidorId}", categoriaId, suplidorId);

            var productos = await _productRepository.ObtenerFiltradosAsync(categoriaId, suplidorId);
            var dtos = productos.Select(p => new ProductoDto(
                p.ProductId, p.ProductName, p.SupplierId, p.Suplidor?.CompanyName, p.CategoryId, p.Categoria?.CategoryName,
                p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued));

            return Result<IEnumerable<ProductoDto>>.Success(dtos);
        }
    }
}
