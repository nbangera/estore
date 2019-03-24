using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Stores
{
    public class Store: Entity
    {
       
        public string Name { get; set; }

        public string Url { get; set; }

        public bool SslEnabled { get; set; }

        public string SecureUrl { get; set; }

        public bool ForceSslForAllPages { get; set; }

        public string Hosts { get; set; }
 
        public long LogoPictureId { get; set; }

        public int DisplayOrder { get; set; }

        public string HtmlBodyId { get; set; }

        public string ContentDeliveryNetwork { get; set; }
   
        public long DefaultWarehouseId { get; set; }

        public long DefaultLanguageId { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string CompanyEmail { get; set; }

        public int PrimaryStoreCurrencyId { get; set; }

        public int PrimaryExchangeRateCurrencyId { get; set; }

        public virtual Currency PrimaryStoreCurrency { get; set; }
        
        public virtual Currency PrimaryExchangeRateCurrency { get; set; }
    }
}
