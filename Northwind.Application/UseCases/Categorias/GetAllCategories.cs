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
    public class GetAllCategories
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<GetAllCategories> _logger;

        public GetAllCategories(ICategoryRepository categoryRepository, ILogger<GetAllCategories> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<CategoriaDto>>> EjecutarAsync()
        {
            _logger.LogInformation("Consultando todas las categorías");

            var categorias = await _categoryRepository.GetAllCategoriesAsync();
            var dtos = categorias.Select(c => new CategoriaDto(c.CategoryId, c.CategoryName ?? string.Empty, c.Description));

            return Result<IEnumerable<CategoriaDto>>.Success(dtos);
        }
    }
}
