using Ecommerce.Application.Infrastructure.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Commands.Create
{
    public class CreateProductCommand: Content,IRequest<string>
    {
       
    }
}
