﻿using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Catalog
{
    /// <summary>
    /// Represents a product category mapping
    /// </summary>
    public partial class ProductCategory : Entity
    {

        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public long ProductId { get; set; }
        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the product is featured
        /// </summary>
        public bool IsFeaturedProduct { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }

    }
}
