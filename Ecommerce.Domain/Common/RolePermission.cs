using Ecommerce.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public class RolePermission:Entity
    {

        public long RoleId { get; set; }

        public Role Role { get; set; }

        public long PermissionId { get; set; }

        public Permission Permission { get; set; }
    }
}
