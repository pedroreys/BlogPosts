using System.Web;
using System.Web.Mvc;
using MvcContrib.ActionResults;

namespace ContentType.ContentTypeHandlers
{
	public class XmlHandler : IContentTypeHandler
	{
		public const string _acceptedType = "text/xml";

		public bool CanHandle(HttpContextBase context)
		{
			var acceptHeader = context.Request.Headers.Get("Accept");

			return acceptHeader.Contains(_acceptedType);
		}

		public ActionResult ResultWith(object model)
		{
			return new XmlResult(model);
		}
	}
}