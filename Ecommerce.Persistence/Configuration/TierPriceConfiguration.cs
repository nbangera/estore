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
    public class TierPriceConfiguration : EntityTypeConfiguration<TierPrice>
    {
        public TierPriceConfiguration()
        {
            this.ToTable("TierPrice");
            this.HasKey(t => t.Id);
            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedTierPrices).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedTierPrices).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);
        }
    }
}
