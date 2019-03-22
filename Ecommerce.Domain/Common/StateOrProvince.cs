using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public class StateOrProvince:Entity
    {
     
        public int CountryId { get; set; }

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public virtual Country Country { get; set; }
    }
}
