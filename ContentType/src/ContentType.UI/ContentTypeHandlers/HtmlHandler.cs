using System.Web;
using System.Web.Mvc;

namespace ContentType.ContentTypeHandlers
{
	public class HtmlHandler : IContentTypeHandler
	{
		public const string _acceptedType = "text/html";
		
		public bool CanHandle(HttpContextBase context)
		{
			var acceptHeader = context.Request.Headers.Get("Accept");

			return acceptHeader.Contains(_acceptedType);
			
		}

		public ActionResult ResultWith(object model)
		{
			return new ViewResult
			       	{
			       		ViewData = new ViewDataDictionary(model),
			       	};
		}
	}
}