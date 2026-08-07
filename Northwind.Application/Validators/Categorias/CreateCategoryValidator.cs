using FluentValidation;
using Northwind.Application.DTOs;

namespace Northwind.Application.Validators.Categorias
{
    public class CreateCategoryValidator : AbstractValidator<CrearCategoriaRequest>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("El nombre de la categoría es obligatorio.")
            .MaximumLength(50).WithMessage("El nombre de la categoría no puede exceder los 50 caracteres.");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("La descripción de la categoría no puede exceder los 200 caracteres.")
            .When(x => !string.IsNullOrEmpty(x.Description));

        }      
    }
}

