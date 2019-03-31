using Ecommerce.Application.Catalog.Product.Queries.GetProductDetail;
using Ecommerce.Application.Catalog.Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce.Web.Api.Controllers
{
    public class ProductController : ApiController
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IHttpActionResult Get(long Id)
        {
            return Ok(_productService.GetProduct(Id));
        }
    }
}
