using Ecommerce.Domain.Catalog;
using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Configuration
{
    public class ProductManufacturerConfiguration: EntityTypeConfiguration<ProductManufacturer>
    {
        public ProductManufacturerConfiguration()
        {
            this.ToTable("ProductManufacturer");
            this.HasKey(t => t.Id);
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedProductManufacturers).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedProductManufacturers).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);
            HasRequired<Product>(t => t.Product).WithMany(u => u.ProductManufacturers).HasForeignKey(t => t.ProductId).WillCascadeOnDelete(false);
            HasRequired<Manufacturer>(t => t.Manufacturer).WithMany(u => u.ProductManufacturers).HasForeignKey(t => t.ManufacturerId).WillCascadeOnDelete(false);
        }
    }
}
