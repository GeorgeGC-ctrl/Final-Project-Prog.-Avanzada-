using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Productos
{
    public class ReassignSupplier
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ReassignSupplier> _logger;

        public ReassignSupplier(IProductRepository productRepository, ILogger<ReassignSupplier> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(ReasignarSuplidorRequest request)
        {
            if (request.SuplidorOrigenId == request.SuplidorDestinoId)
            {
                _logger.LogWarning("El proveedor de origen y destino son iguales: {Id}", request.SuplidorOrigenId);
                return Result.Failure("El proveedor de origen y destino no pueden ser el mismo.");
            }

            _logger.LogInformation("Reasignando productos del proveedor {Origen} al proveedor {Destino}", request.SuplidorOrigenId, request.SuplidorDestinoId);

            await _productRepository.ReasignarSuplidorAsync(request.SuplidorOrigenId, request.SuplidorDestinoId);

            return Result.Success();
        }
    }
}
