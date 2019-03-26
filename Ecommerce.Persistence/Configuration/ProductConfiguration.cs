using Ecommerce.Domain.Catalog;
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

        }
    }
}
