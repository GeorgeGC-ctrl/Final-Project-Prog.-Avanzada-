using FluentValidation;
using Northwind.Application.DTOs;

namespace Northwind.Application.Validators.Productos
{
    public class CreateProductValidator : AbstractValidator<CrearProductoRequest>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.ProductName)
               .NotEmpty().WithMessage("El nombre del producto es obligatorio.")
               .MaximumLength(40).WithMessage("El nombre no debe superar los 40 caracteres.");
            RuleFor(x => x.UnitPrice)
                .GreaterThanOrEqualTo(0).When(x => x.UnitPrice.HasValue)
                .WithMessage("El precio unitario no puede ser negativo.");
            RuleFor(x => x.UnitsInStock)
                .GreaterThanOrEqualTo((short)0).When(x => x.UnitsInStock.HasValue)
                .WithMessage("Las unidades en stock no pueden ser negativas.");
        }
    }
}


