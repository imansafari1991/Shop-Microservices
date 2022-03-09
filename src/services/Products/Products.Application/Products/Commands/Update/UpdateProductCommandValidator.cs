using FluentValidation;
using Products.Application.Products.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Commands.Update
{
    public class UpdateProductCommandValidator:AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{Title} is Required")
                .NotNull()
                .MaximumLength(200).WithMessage("{Title} must not exceed 10 characters");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{Description} is Required")
                .NotNull()
                .MaximumLength(5000).WithMessage("{Description} must not exceed 10 characters");

            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("{CategoryId} is Required")
                .NotEqual(0).WithMessage("{Category} must not be zero");

            RuleFor(p => p.Price)
                .NotNull().WithMessage("{Price} is Required")
                .GreaterThanOrEqualTo(0).WithMessage("{Price} must not be less than");

        }

    }
}
