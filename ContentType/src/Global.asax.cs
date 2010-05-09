using System.Web.Mvc;
using System.Web.Routing;
using ContentType.DependencyResolution;

namespace ContentType
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			StructureMapBootstrapper.Bootstrap();
			AreaRegistration.RegisterAllAreas();
			ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
			RegisterRoutes(RouteTable.Routes);
		}
	}
}