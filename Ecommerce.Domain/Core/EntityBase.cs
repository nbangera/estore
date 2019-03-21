using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Core
{
    public abstract class EntityBase : IEntityBase<long>
    {
       
        public EntityBase()
        {
            if (CreatedOn != default(DateTimeOffset))
            {
                CreatedOn = DateTimeOffset.Now;
            }

            LatestUpdatedOn = DateTimeOffset.Now;
        }
        public virtual long Id { get; protected set; }

        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset CreatedOn { get; protected set; }

        public DateTimeOffset LatestUpdatedOn { get; protected set; }

    }
}
