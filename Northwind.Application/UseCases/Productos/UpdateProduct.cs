using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Productos
{
    public class UpdateProduct
    {
        private readonly IProductRepository _productRepository;
        private readonly IValidator<EditarProductoRequest> _validator;
        private readonly ILogger<UpdateProduct> _logger;

        public UpdateProduct(IProductRepository productRepository, IValidator<EditarProductoRequest> validator, ILogger<UpdateProduct> logger)
        {
            _productRepository = productRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(EditarProductoRequest request)
        {
            _logger.LogInformation("Iniciando actualización de producto: {Id}", request.ProductId);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la actualización de producto: {Errores}", errors);
                return Result.Failure(errors);
            }

            var producto = await _productRepository.ObtenerPorIdAsync(request.ProductId);
            if (producto is null)
            {
                _logger.LogWarning("No se encontró el producto con ID: {Id}", request.ProductId);
                return Result.Failure($"No se encontró el producto con ID {request.ProductId}.");
            }

            producto.ProductName = request.ProductName;
            producto.SupplierId = request.SupplierId;
            producto.CategoryId = request.CategoryId;
            producto.QuantityPerUnit = request.QuantityPerUnit;
            producto.UnitPrice = request.UnitPrice;
            producto.UnitsInStock = request.UnitsInStock;
            producto.UnitsOnOrder = request.UnitsOnOrder;
            producto.ReorderLevel = request.ReorderLevel;
            producto.Discontinued = request.Discontinued;

            await _productRepository.ActualizarAsync(producto);
            _logger.LogInformation("Producto con ID: {Id} actualizado exitosamente", request.ProductId);

            return Result.Success();
        }
    }
}
