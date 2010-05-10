using System.Linq;
using System.Web;

namespace ContentType.ContentTypeHandlers
{
	public interface IContentTypeHandlerRepository
	{
		IContentTypeHandler GetHandlerFor(HttpContextBase context);
	}

	public class ContentTypeHandlerRepository : IContentTypeHandlerRepository
	{
		private readonly IContentTypeHandler[] _handlers;

		public ContentTypeHandlerRepository(IContentTypeHandler[] handlers)
		{
			_handlers = handlers;
		}

		public IContentTypeHandler GetHandlerFor(HttpContextBase context)
		{
			return _handlers.First(x => x.CanHandle(context));
		}
	}
}