using CrediSoft.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediSoft.Application.Validators.Clients
{
    public class UpdateClientValidator : AbstractValidator<CreateClientDto>
    {
        public UpdateClientValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Full name is required.")
                .MaximumLength(100).WithMessage("The name cannot exceed 100 characters.");

            RuleFor(x => x.DocumentNumber)
                .NotEmpty().WithMessage("The document number is required.")
                .Length(11).WithMessage("The document number must have 11 digits..");

            RuleFor(x => x.CreditLimit)
                .GreaterThan(0).WithMessage("The credit limit must be greater than 0.");
        }
    }
}
