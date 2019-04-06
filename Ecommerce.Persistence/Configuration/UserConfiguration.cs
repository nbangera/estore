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
    public class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable("User");
            this.HasKey(t => t.Id);

            HasRequired<User>(t => t.CreatedBy).WithMany(u => u.CreatedUsers).HasForeignKey<long>(t => t.CreatedById).WillCascadeOnDelete(false);
            HasRequired<User>(t => t.LatestUpdatedBy).WithMany(u => u.ModifiedUsers).HasForeignKey<long>(t => t.LatestUpdatedById).WillCascadeOnDelete(false);

           
        }
    }
}
