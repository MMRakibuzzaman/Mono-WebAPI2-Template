using System;
using System.Web;
using System.Web.Http;
using WebApplication1.WebApplication1;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}