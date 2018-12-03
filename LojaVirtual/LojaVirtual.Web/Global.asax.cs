using LojaVirtual.Web.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

            UnityMvcActivator.Start();
        }
    }
}
