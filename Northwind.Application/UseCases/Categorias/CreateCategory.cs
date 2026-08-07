using FluentValidation;
using Northwind.Application.DTOs;
using Northwind.Application.Validators.Categorias;
using Northwind.Domain.Common;
using Northwind.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Logging;

namespace Northwind.Application.UseCases.Categorias
{
    public class CreateCategory
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IValidator<CrearCategoriaRequest> _validator;
        private readonly ILogger<CreateCategory> _logger;

        public CreateCategory(ICategoryRepository categoryRepository, IValidator<CrearCategoriaRequest> validator, ILogger<CreateCategory> logger)
        {
            _categoryRepository = categoryRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result<int>> EjecurarAsync(CrearCategoriaRequest request)
        {

            _logger.LogInformation("Iniciando creación de categoría: {Nombre}", request.CategoryName);

            var validationResult = await _validator.ValidateAsync(request);
            if(!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la creación de categoría: {Errores}", errors);
                return Result<int>.Failure(errors);
            }
            var category = new Categories
            {
                CategoryName = request.CategoryName,
                Description = request.Description
            };

            await _categoryRepository.CreateCategoryAsync(category);
            _logger.LogInformation("Categoría creada exitosamente con ID: {Id}", category.CategoryId);

            return Result<int>.Success(category.CategoryId);
        }
    }
}
