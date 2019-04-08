using Ecommerce.Domain.Common;
using Ecommerce.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Catalog
{
    public class Product:Content
    {
        

        public virtual ICollection<TierPrice> TierPrices { get; set; } = new List<TierPrice>();
        public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public virtual ICollection<ProductManufacturer> ProductManufacturers { get; set; } = new List<ProductManufacturer>();

        public bool ShowOnHomePage { get; set; }

        public long StoreId { get; set; }

        public virtual Store Store { get; set; }
    }
}
