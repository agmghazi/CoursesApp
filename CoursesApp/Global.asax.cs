using System.Web.Mvc;
using System.Web.Routing;

namespace CoursesApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.DefaultNamespaces.Add("CoursesApp.Controllers"); // Add This to add default config

        }
    }
}
