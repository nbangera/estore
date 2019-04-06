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
    public class ProductCategoryConfiguration: EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryConfiguration()
        {
            this.ToTable("ProductCategory");
            this.HasKey(t => t.Id);
            HasRequired<Product>(t => t.Product).WithMany(u => u.ProductCategories).HasForeignKey(t => t.ProductId).WillCascadeOnDelete(false);
            HasRequired<Category>(t => t.Category).WithMany(u => u.ProductCategories).HasForeignKey(t => t.CategoryId).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedProductCategories).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedProductCategories).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);
        }
    }
}
