using Microsoft.Extensions.Logging;
using Northwind.Application.Validators.Suplidores;
using Northwind.Domain.Common;

namespace Northwind.Application.UseCases.Suplidores
{
    public class DeleteSupplier
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ILogger<DeleteSupplier> _logger;

        public DeleteSupplier(ISupplierRepository supplierRepository, ILogger<DeleteSupplier> logger)
        {
            _supplierRepository = supplierRepository;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(int id)
        {
            _logger.LogInformation("Iniciando eliminación de proveedor con ID: {Id}", id);

            var productosAsociados = await _supplierRepository.TieneProductosAsociadosAsync(id);
            if (productosAsociados)
            {
                _logger.LogWarning("No se puede eliminar el proveedor con ID: {Id} porque tiene productos asociados", id);
                return Result.Failure($"No se puede eliminar el proveedor con ID {id} porque tiene productos asociados.");
            }

            await _supplierRepository.EliminarAsync(id);
            _logger.LogInformation("Proveedor con ID: {Id} eliminado exitosamente", id);

            return Result.Success();
        }
    }
}
