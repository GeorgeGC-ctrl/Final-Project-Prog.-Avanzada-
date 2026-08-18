using FluentValidation;
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
    public class UpdateCategory
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IValidator<EditarCategoriaRequest> _validator;
        private readonly ILogger<UpdateCategory> _logger;

        public UpdateCategory(ICategoryRepository categoryRepository, IValidator<EditarCategoriaRequest> validator, ILogger<UpdateCategory> logger)
        {
            _categoryRepository = categoryRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Result> EjecutarAsync(EditarCategoriaRequest request)
        {
            _logger.LogInformation("Iniciando actualización de categoría: {Id}", request.CategoryId);

            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                _logger.LogWarning("Validación fallida para la actualización de categoría: {Errores}", errors);
                return Result.Failure(errors);
            }

            var categoria = await _categoryRepository.GetCategoryByIdAsync(request.CategoryId);
            if (categoria is null)
            {
                _logger.LogWarning("No se encontró la categoría con ID: {Id}", request.CategoryId);
                return Result.Failure($"No se encontró la categoría con ID {request.CategoryId}.");
            }

            categoria.CategoryName = request.CategoryName;
            categoria.Description = request.Description;

            await _categoryRepository.UpdateCategoryAsync(categoria);
            _logger.LogInformation("Categoría con ID: {Id} actualizada exitosamente", request.CategoryId);

            return Result.Success();
        }
    }
}
