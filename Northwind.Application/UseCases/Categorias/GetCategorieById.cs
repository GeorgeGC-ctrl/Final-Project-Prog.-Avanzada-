using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.UseCases.Categorias
{
    public class GetCategoryById
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<GetCategoryById> _logger;

        public GetCategoryById(ICategoryRepository categoryRepository, ILogger<GetCategoryById> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<Result<CategoriaDto>> EjecutarAsync(int id)
        {
            _logger.LogInformation("Consultando categoría con ID: {Id}", id);

            var categoria = await _categoryRepository.GetCategoryByIdAsync(id);
            if (categoria is null)
            {
                _logger.LogWarning("No se encontró la categoría con ID: {Id}", id);
                return Result<CategoriaDto>.Failure($"No se encontró la categoría con ID {id}.");
            }

            var dto = new CategoriaDto(categoria.CategoryId, categoria.CategoryName ?? string.Empty, categoria.Description);
            return Result<CategoriaDto>.Success(dto);
        }
    }
}
