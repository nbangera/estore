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
    public class CategoryConfiguration: EntityTypeConfiguration<Category>
    {

        public CategoryConfiguration()
        {
            this.ToTable("Category");
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedCategories).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedCategories).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);
        }
    }
}
