using Ecommerce.Domain.Common;
using Ecommerce.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Persistence.Configuration
{
    public class StoreConfiguration: EntityTypeConfiguration<Store>
    {

        public StoreConfiguration()
        {
            this.ToTable("Store");
            this.HasKey(t => t.Id);
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedStores).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedStores).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);
        }
    }
}
