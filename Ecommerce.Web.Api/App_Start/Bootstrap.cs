using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ecommerce.Web.Api.App_Start
{
    public static class Bootstrap
    {
        public static void Run()
        {
            AutofacConfig.Initialize(GlobalConfiguration.Configuration);
        }
        
    }
}