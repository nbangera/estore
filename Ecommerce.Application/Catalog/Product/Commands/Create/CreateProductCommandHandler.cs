using Ecommerce.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,string>
    {

        private readonly ApplicationDbContext _context;
        
        public CreateProductCommandHandler(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
