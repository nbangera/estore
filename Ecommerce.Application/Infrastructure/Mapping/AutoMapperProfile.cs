using AutoMapper;
using Ecommerce.Application.Catalog.Product.Commands.Create;
using Ecommerce.Application.Catalog.Product.Queries.GetProductDetail;
using Ecommerce.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Infrastructure.Mapping
{
    public class ViewModelToDomainAutoMapperProfile:Profile
    {
        public ViewModelToDomainAutoMapperProfile()
        {
            CreateMap<CreateProductCommand, Product>();
            
        }
    }


    public class DomainToViewModelAutoMapperProfile : Profile
    {
        public DomainToViewModelAutoMapperProfile()
        {
            CreateMap<Product,CreateProductCommand>();
            CreateMap<Product, ProductDetailModel>();
        }
    }


}
