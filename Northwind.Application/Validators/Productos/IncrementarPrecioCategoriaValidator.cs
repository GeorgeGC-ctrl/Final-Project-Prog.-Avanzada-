using FluentValidation;
using Northwind.Application.DTOs;

namespace Northwind.Application.Validators.Productos
{
    public class IncrementarPrecioCategoriaValidator : AbstractValidator<IncrementarPrecioCategoriaRequest>
    {
        public IncrementarPrecioCategoriaValidator()
        {
            RuleFor(x => x.CategoriaId)
                .GreaterThan(0).WithMessage("Debe seleccionar una categoría.");

            RuleFor(x => x.Porcentaje)
                .GreaterThan(0).WithMessage("El porcentaje debe ser mayor a 0.")
                .LessThanOrEqualTo(1000).WithMessage("El porcentaje no puede superar 1000.");
        }
    }
}