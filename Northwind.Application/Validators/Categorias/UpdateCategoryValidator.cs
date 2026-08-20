using FluentValidation;
using Northwind.Application.DTOs;

namespace Northwind.Application.Validators.Categorias
{
    public class UpdateCategoryValidator : AbstractValidator<EditarCategoriaRequest>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("El ID de la categoría debe ser mayor a 0.");

            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("El nombre de la categoría es obligatorio.")
                .MaximumLength(50).WithMessage("El nombre de la categoría no puede exceder los 50 caracteres.");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("La descripción de la categoría no puede exceder los 200 caracteres.")
                .When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
