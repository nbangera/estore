﻿using Ecommerce.Domain.Common;
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

        public virtual ICollection<ManufacturerStore> Stores { get; set; } = new List<ManufacturerStore>();

        public virtual ICollection<ProductManufacturer> ProductManufacturers { get; set; } = new List<ProductManufacturer>();

    }
}
