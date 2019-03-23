﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public class UserRole:Entity
    {
        
        public long UserId { get; set; }

        public User User { get; set; }

        public long RoleId { get; set; }

        public Role Role { get; set; }
    }
}
