﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Product.Queries.GetProductDetail
{
    public class GetProductDetailQuery:IRequest<ProductDetailModel>
    {
        public long Id { get; set; }
    }
}
