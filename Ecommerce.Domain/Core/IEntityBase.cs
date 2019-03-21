using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Core
{
    public interface IEntityBase<TId>
    {
        TId Id { get; }

        bool IsDeleted { get; set; }

        bool IsActive { get; set; }

        DateTimeOffset CreatedOn { get; }

        DateTimeOffset LatestUpdatedOn { get; }


    }
}
