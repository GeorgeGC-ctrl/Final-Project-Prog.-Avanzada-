using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Common;
using Northwind.Domain.Entidades;

namespace Northwind.Application.UseCases.Suplidores
{
    public class CreateSupplier
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IValidator<CrearSuplidorRequest> _validator;
        private readonly ILogger<CreateSupplier> _logger;

        public CreateSupplier(ISupplierRepository supplierRepository, IValidator<CrearSuplidorRequest> validator, ILogger<CreateSupplier> logger)
        {
            _supplierRepository = supplierRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result<int>> EjecutarAsync(CrearSuplidorRequest request)
        {
            _logger.LogInformation("Iniciando creación de proveedor: {Empresa}", request.CompanyName);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la creación de proveedor: {Errores}", errors);
                return Result<int>.Failure(errors);
            }

            var suplidor = new Suppliers
            {
                CompanyName = request.CompanyName,
                ContactName = request.ContactName,
                ContactTitle = request.ContactTitle,
                Phone = request.Phone,
                Country = request.Country,
                City = request.city
            };

            await _supplierRepository.CrearAsync(suplidor);
            _logger.LogInformation("Proveedor creado exitosamente con ID: {Id}", suplidor.SupplierId);

            return Result<int>.Success(suplidor.SupplierId);
        }
    }
}
