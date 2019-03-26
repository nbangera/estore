using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Commands.Create
{
    public class CreateProductCommandValidator: AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name).Length(200).NotEmpty();
            RuleFor(x => x.MetaTitle).Length(500).NotEmpty();
            RuleFor(x => x.MetaDescription).MaximumLength(8000);
        }
    }
}
