using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Suplidores
{
    public class GetSuppliers
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<GetSuppliers> _logger;

        public GetSuppliers(ISupplierRepository supplierRepository, ILogger<GetSuppliers> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<SuplidorDto>>> EjecutarAsync()
        {
            _logger.LogInformation("Consultando todos los proveedores");

            var suplidores = await _supplierRepository.ObtenerTodosAsync();
            var dtos = suplidores.Select(s => new SuplidorDto(
                s.SupplierId, s.CompanyName, s.ContactName, s.ContactTitle, s.Phone, s.Country, s.City ?? string.Empty));

            return Result<IEnumerable<SuplidorDto>>.Success(dtos);
        }
    }
}
