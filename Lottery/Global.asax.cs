using System.Web.Http;
using Lottery.Models.Mapping;

namespace Lottery
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            MapConfigurator.Configure();
        }
    }
}
