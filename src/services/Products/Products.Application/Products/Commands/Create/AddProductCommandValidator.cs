using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Products.Domain;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommandValidator:AbstractValidator<AddProductCommand>
    {
       
        public AddProductCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{Title} is Required")
                .NotNull()
                .MaximumLength(200).WithMessage("{Title} must not exceed 200 characters");
            RuleFor(p => p.Description)
                .NotEmpty().WithMessage("{Description} is Required")
                .NotNull()
                .MaximumLength(5000).WithMessage("{Description} must not exceed 5000 characters");

            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("{CategoryId} is Required")
                .NotEqual(0).WithMessage("{Category} must not be zero");

            RuleFor(p => p.Price)
                .NotNull().WithMessage("{Price} is Required")
                .GreaterThanOrEqualTo(0).WithMessage("{Price} must not be less than zero");




        }
    }
}
