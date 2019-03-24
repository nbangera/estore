using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public class Currency
    {
        public string Name { get; set; }

        public string CurrencyCode { get; set; }

        public decimal Rate { get; set; }

        public string DisplayLocale { get; set; }

        public string CustomFormatting { get; set; }

        public bool LimitedToStores { get; set; }

        public bool Published { get; set; }

        public int DisplayOrder { get; set; }

        private NumberFormatInfo _numberFormat;

        [NotMapped]
        public NumberFormatInfo NumberFormat
        {
            get
            {
                if (_numberFormat == null && !string.IsNullOrEmpty(DisplayLocale))
                {
                    try
                    {
                        _numberFormat = CultureInfo.CreateSpecificCulture(DisplayLocale).NumberFormat;
                    }
                    catch { }
                }

                if (_numberFormat == null)
                {
                    _numberFormat = NumberFormatInfo.CurrentInfo;
                }

                return _numberFormat;
            }
        }
    }
}
