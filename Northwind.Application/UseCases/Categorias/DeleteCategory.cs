using Microsoft.Extensions.Logging;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Common;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.UseCases.Categorias
{
    public class DeleteCategory
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<DeleteCategory> _logger;
        public DeleteCategory(ICategoryRepository categoryRepository, ILogger<DeleteCategory> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }
        public async Task<Result> EjectarAsync(int id)
        {
         _logger.LogInformation("Iniciando eliminación de categoría con ID: {Id}", id);
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
           
            bool productosAsociados = await _categoryRepository.TieneProductosAsociadosAsync(id);

            if (productosAsociados )
            {
                _logger.LogWarning("No se puede eliminar la categoría con ID: {Id} porque tiene productos asociados", id);
                return Result.Failure($"No se puede eliminar la categoría con ID {id} porque tiene productos asociados.");
            }

            await _categoryRepository.DeleteCategoryAsync(id);
            _logger.LogInformation("Categoría con ID: {Id} eliminada exitosamente", id);
            return Result.Success();
        }
    }
}
