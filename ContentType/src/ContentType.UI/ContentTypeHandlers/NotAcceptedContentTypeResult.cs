using System;
using System.Web.Mvc;

namespace ContentType.ContentTypeHandlers
{
	public class NotAcceptedContentTypeResult : ActionResult
	{

		public override void ExecuteResult(ControllerContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			context.HttpContext.Response.StatusCode = 406;
		}
	}
}