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
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        public long StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
