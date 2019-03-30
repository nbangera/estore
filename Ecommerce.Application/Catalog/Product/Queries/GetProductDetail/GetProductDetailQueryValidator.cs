using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Queries.GetProductDetail
{
    public class GetProductDetailQueryValidator:AbstractValidator<GetProductDetailQuery>
    {
        public GetProductDetailQueryValidator()
        {
            RuleFor(t => t.Id).NotEmpty();
        }
    }
}
