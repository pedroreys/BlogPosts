using ContentType.ContentTypeHandlers;
using StructureMap.Configuration.DSL;

namespace ContentType.DependencyResolution
{
	public class DependencyRegistry : Registry
	{
		public DependencyRegistry()
		{
			Scan(x =>
			     	{
			     		x.TheCallingAssembly();
			     		x.WithDefaultConventions();
			     	});

			For<IContentTypeHandlerRepository>()
				.Use<ContentTypeHandlerRepository>()
				.EnumerableOf<IContentTypeHandler>()
				.Contains(x =>
				          	{
				          		x.Type<HtmlHandler>();
				          		x.Type<JsonHandler>();
				          		x.Type<XmlHandler>();
				          		x.Type<NotAcceptedContentTypeHandler>();
				          	});

			SetAllProperties(x => x.OfType<IContentTypeHandlerRepository>());
		}
	}
}