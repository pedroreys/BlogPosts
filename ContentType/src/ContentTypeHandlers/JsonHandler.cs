using System.Web;
using System.Web.Mvc;

namespace ContentType.ContentTypeHandlers
{
	public class JsonHandler : IContentTypeHandler
	{
		public const string _acceptedType = "application/json";
		
		public bool CanHandle(HttpContextBase context)
		{
			var acceptHeader = context.Request.Headers.Get("Accept");

			return acceptHeader.Contains(_acceptedType);
		}

		public ActionResult ResultWith(object model)
		{
			return new JsonResult
			       	{
			       		Data = model,
			       		ContentEncoding = null,
						JsonRequestBehavior = JsonRequestBehavior.AllowGet
			       	};
		}
	}
}