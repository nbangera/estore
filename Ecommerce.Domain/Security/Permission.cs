using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Security
{
    public class Permission:Entity
    {
        public string Name { get; set; }
        public Guid PermissionCode { get; set; }
        public PermissionCategory Category { get; set; }
    }
}
