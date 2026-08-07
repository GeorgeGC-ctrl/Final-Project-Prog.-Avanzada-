using FluentValidation;
using Northwind.Application.DTOs;


namespace Northwind.Application.Validators.Suplidores
{
    public class SuppliersValidator : AbstractValidator<CrearSuplidorRequest>
    {
        public SuppliersValidator()
        {
            RuleFor(s => s.CompanyName)
                .NotEmpty().WithMessage("El nombre de la compañía es obligatorio.")
                .MaximumLength(40).WithMessage("El nombre de la compañía no puede exceder los 40 caracteres.");
            RuleFor(s => s.ContactName)
                .NotEmpty().WithMessage("El nombre del contacto no puede estar vacio.");
           
            RuleFor(s => s.city)
                .MaximumLength(15).WithMessage("La ciudad no puede exceder los 15 caracteres.");
            RuleFor(s => s.Country)
                .MaximumLength(15).WithMessage("El país no puede exceder los 15 caracteres.");
            RuleFor(s => s.Phone)
                .MaximumLength(24).WithMessage("El teléfono no puede exceder los 24 caracteres.");
           
        }

    }
}