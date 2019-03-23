using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Ecommerce.Domain.Common
{
    public class Role:Entity
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
        public IList<RolePermission> Permissions { get; set; } = new List<RolePermission>();

    }
}
