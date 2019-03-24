using Ecommerce.Domain.Common;
using Ecommerce.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Catalog
{
    public class Manufacturer:Entity
    {
      
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Store> Stores { get; set; } = new List<Store>();
        
    }
}
