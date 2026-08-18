using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Suplidores
{
    public class GetSupplierById
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<GetSupplierById> _logger;

        public GetSupplierById(ISupplierRepository supplierRepository, ILogger<GetSupplierById> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }

        public async Task<Result<SuplidorDto>> EjecutarAsync(int id)
        {
            _logger.LogInformation("Consultando proveedor con ID: {Id}", id);

            var suplidor = await _supplierRepository.ObtenerPorIdAsync(id);
            if (suplidor is null)
            {
                _logger.LogWarning("No se encontró el proveedor con ID: {Id}", id);
                return Result<SuplidorDto>.Failure($"No se encontró el proveedor con ID {id}.");
            }

            var dto = new SuplidorDto(
                suplidor.SupplierId, suplidor.CompanyName, suplidor.ContactName, suplidor.ContactTitle,
                suplidor.Phone, suplidor.Country, suplidor.City ?? string.Empty);

            return Result<SuplidorDto>.Success(dto);
        }
    }
}
