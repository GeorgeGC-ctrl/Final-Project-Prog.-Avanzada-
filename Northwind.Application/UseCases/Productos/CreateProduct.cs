using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;
using Northwind.Domain.Entidades;

namespace Northwind.Application.UseCases.Productos
{
    public class CreateProduct
    {
        private readonly IProductRepository _productRepository;
        private readonly IValidator<CrearProductoRequest> _validator;
        private readonly ILogger<CreateProduct> _logger;

        public CreateProduct(IProductRepository productRepository, IValidator<CrearProductoRequest> validator, ILogger<CreateProduct> logger)
        {
            _productRepository = productRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result<int>> EjecutarAsync(CrearProductoRequest request)
        {
            _logger.LogInformation("Iniciando creación de producto: {Nombre}", request.ProductName);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la creación de producto: {Errores}", errors);
                return Result<int>.Failure(errors);
            }

            var producto = new Products
            {
                ProductName = request.ProductName,
                SupplierId = request.SupplierId,
                CategoryId = request.CategoryId,
                QuantityPerUnit = request.QuantityPerUnit,
                UnitPrice = request.UnitPrice,
                UnitsInStock = request.UnitsInStock,
                UnitsOnOrder = request.UnitsOnOrder,
                ReorderLevel = request.ReorderLevel
            };

            await _productRepository.CrearAsync(producto);
            _logger.LogInformation("Producto creado exitosamente con ID: {Id}", producto.ProductId);

            return Result<int>.Success(producto.ProductId);
        }
    }
}
