using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Common
{
    public class Media : Entity
    {
        public string Caption { get; set; }

        public int FileSize { get; set; }

        public string FileName { get; set; }

        public string MimeType { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string SeoFilename { get; set; }

        public MediaType MediaType { get; set; }

    }
}
