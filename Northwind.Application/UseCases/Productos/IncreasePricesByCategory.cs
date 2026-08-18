using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Productos;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Productos
{
    public class IncreasePricesByCategory
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<IncreasePricesByCategory> _logger;

        public IncreasePricesByCategory(IProductRepository productRepository, ILogger<IncreasePricesByCategory> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(IncrementarPrecioCategoriaRequest request)
        {
            if (request.Porcentaje <= 0)
            {
                _logger.LogWarning("Porcentaje de incremento inválido: {Porcentaje}", request.Porcentaje);
                return Result.Failure("El porcentaje debe ser mayor a 0.");
            }

            _logger.LogInformation("Incrementando precios {Porcentaje}% para la categoría {CategoriaId}", request.Porcentaje, request.CategoriaId);

            await _productRepository.IncrementarPreciosPorCategoriaAsync(request.CategoriaId, request.Porcentaje);

            return Result.Success();
        }
    }
}
