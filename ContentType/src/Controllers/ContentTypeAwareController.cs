using System.Web.Mvc;
using ContentType.ContentTypeHandlers;

namespace ContentType.Controllers
{
    public class ContentTypeAwareController : Controller
    {
    	public virtual IContentTypeHandlerRepository HandlerRepository { get; set; }

    	protected ActionResult ResultWith(object model)
		{
			var handler = HandlerRepository.GetHandlerFor(HttpContext);
			return handler.ResultWith(model);
		}

    
    }
}