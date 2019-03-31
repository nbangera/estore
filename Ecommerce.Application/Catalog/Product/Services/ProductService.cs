using Ecommerce.Application.Catalog.Product.Commands.Create;
using Ecommerce.Application.Catalog.Product.Queries.GetProductDetail;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Services
{
    public class ProductService : IProductService
    {
        private readonly IMediator _mediator;
        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> CreateProduct(CreateProductCommand command)
        {
            string productId = await _mediator.Send(command);
            return productId;
        }

        public async Task<ProductDetailModel> GetProduct(long Id)
        {
            ProductDetailModel product = await _mediator.Send(new GetProductDetailQuery { Id = Id });
            return product;
        }
    }
}
