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
    public class ProductConfiguration:EntityTypeConfiguration<Product>
    {

        public ProductConfiguration()
        {
            this.ToTable("Product");
            this.HasKey(t => t.Id);
            this.Property(t => t.MetaTitle).HasMaxLength(500);
            this.Property(t => t.Name).HasMaxLength(200);
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedProducts).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedProducts).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);

        }
    }
}
