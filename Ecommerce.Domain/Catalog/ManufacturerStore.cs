using Ecommerce.Domain.Common;
using Ecommerce.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Catalog
{
    public class ManufacturerStore:Entity
    {
     
            public long ManufacturerId { get; set; }

            public long StoreId { get; set; }

            public virtual Store Store { get; set; }

            public virtual Manufacturer Manufacturer { get; set; }
      
    }
}
