using System;
using System.Web.Mvc;
using StructureMap;

namespace ContentType.DependencyResolution
{
	public class ControllerFactory : DefaultControllerFactory
	{
		
		protected override Type GetControllerType(System.Web.Routing.RequestContext requestContext, string controllerName)
		{
			var result = base.GetControllerType(requestContext, controllerName);
			return result;
		}

		protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
		{
			if (controllerType == null)
				return null;

			object controller = ObjectFactory.GetInstance(controllerType);

			ObjectFactory.BuildUp(controller);

			return (IController)controller;
		}
		
	}
}