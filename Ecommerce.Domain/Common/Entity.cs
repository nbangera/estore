using Ecommerce.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public abstract class Entity:EntityBase
    {
        public long CreatedById { get; set; }

        public long LatestUpdatedById { get; set; }

        public User CreatedBy { get; set; }

        public User LatestUpdatedBy { get; set; }

    }
}
