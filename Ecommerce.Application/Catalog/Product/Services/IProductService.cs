using System.Threading.Tasks;
using Ecommerce.Application.Catalog.Product.Commands.Create;
using Ecommerce.Application.Catalog.Product.Queries.GetProductDetail;

namespace Ecommerce.Application.Catalog.Product.Services
{
    public interface IProductService
    {
        Task<string> CreateProduct(CreateProductCommand command);
        Task<ProductDetailModel> GetProduct(long Id);
    }
}