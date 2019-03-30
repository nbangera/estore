using AutoMapper;
using Ecommerce.Application.Infrastructure.Model.Exceptions;
using Ecommerce.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Queries.GetProductDetail
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetailModel>
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async Task<ProductDetailModel> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FindAsync(request.Id);
            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Catalog.Product), request.Id);
            }
            ProductDetailModel product = _mapper.Map<Domain.Catalog.Product, ProductDetailModel>(entity);
            return product;
        }
    }
}
