using System.Web;
using System.Web.Mvc;

namespace ContentType.ContentTypeHandlers
{
	public class NotAcceptedContentTypeHandler : IContentTypeHandler
	{
		public bool CanHandle(HttpContextBase context)
		{
			return true;
		}

		public ActionResult ResultWith(object model)
		{
			return new NotAcceptedContentTypeResult();
		}
	}
}