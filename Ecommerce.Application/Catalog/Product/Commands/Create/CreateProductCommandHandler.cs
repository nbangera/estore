using AutoMapper;
using Ecommerce.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ecommerce.Domain.Catalog;

namespace Ecommerce.Application.Catalog.Product.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,string>
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        public CreateProductCommandHandler(ApplicationDbContext dbContext,IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            Domain.Catalog.Product product =  _mapper.Map<CreateProductCommand,Domain.Catalog.Product>(request);
            _context.Products.Add(product);
           int result = await _context.SaveChangesAsync();
            return result.ToString();
           
        }
    }
}
