using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Suplidores
{
    public class UpdateSupplier
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IValidator<EditarSuplidorRequest> _validator;
        private readonly ILogger<UpdateSupplier> _logger;

        public UpdateSupplier(ISupplierRepository supplierRepository, IValidator<EditarSuplidorRequest> validator, ILogger<UpdateSupplier> logger)
        {
            _supplierRepository = supplierRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(EditarSuplidorRequest request)
        {
            _logger.LogInformation("Iniciando actualización de proveedor: {Id}", request.SupplierId);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la actualización de proveedor: {Errores}", errors);
                return Result.Failure(errors);
            }

            var suplidor = await _supplierRepository.ObtenerPorIdAsync(request.SupplierId);
            if (suplidor is null)
            {
                _logger.LogWarning("No se encontró el proveedor con ID: {Id}", request.SupplierId);
                return Result.Failure($"No se encontró el proveedor con ID {request.SupplierId}.");
            }

            suplidor.CompanyName = request.CompanyName;
            suplidor.ContactName = request.ContactName;
            suplidor.ContactTitle = request.ContactTitle;
            suplidor.Phone = request.Phone;
            suplidor.Country = request.Country;
            suplidor.City = request.city;

            await _supplierRepository.ActualizarAsync(suplidor);
            _logger.LogInformation("Proveedor con ID: {Id} actualizado exitosamente", request.SupplierId);

            return Result.Success();
        }
    }
}
