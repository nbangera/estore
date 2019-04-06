using Ecommerce.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Stores;

namespace Ecommerce.Domain.Common
{
    public class User:Entity
    {
        public virtual ICollection<Product> ModifiedProducts { get; set; }
        public virtual ICollection<Product> CreatedProducts { get; set; }

        public virtual ICollection<User> ModifiedUsers { get; set; }
        public virtual ICollection<User> CreatedUsers { get; set; }

        public virtual ICollection<ProductCategory> ModifiedProductCategories { get; set; }
        public virtual ICollection<ProductCategory> CreatedProductCategories { get; set; }

        public virtual ICollection<ProductManufacturer> ModifiedProductManufacturers { get; set; }
        public virtual ICollection<ProductManufacturer> CreatedProductManufacturers { get; set; }

        public virtual ICollection<Store> ModifiedStores { get; set; }
        public virtual ICollection<Store> CreatedStores { get; set; }

        public virtual ICollection<TierPrice> ModifiedTierPrices { get; set; }
        public virtual ICollection<TierPrice> CreatedTierPrices { get; set; }

        public virtual ICollection<Category> ModifiedCategories { get; set; }
        public virtual ICollection<Category> CreatedCategories { get; set; }

        public virtual ICollection<Manufacturer> ModifiedManufacturers { get; set; }
        public virtual ICollection<Manufacturer> CreatedManufacturers { get; set; }
    }
}
