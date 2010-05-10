using System.Web;
using System.Web.Mvc;

namespace ContentType.ContentTypeHandlers
{
	public interface IContentTypeHandler
	{
		bool CanHandle(HttpContextBase context);
		ActionResult ResultWith(object model);
	}
}