using ContentType.ContentTypeHandlers;
using MvcContrib.ActionResults;
using NUnit.Framework;
using Should.Extensions.AssertExtensions;

namespace ContentType.Test
{
	[TestFixture]
	public class XmlHandlerTest : HandlerTestBase
	{
		[Test]
		public void should_return_a_XmlResult()
		{
			var handler = new XmlHandler();
			var result = handler.ResultWith("whatever");
			result.ShouldBeType<XmlResult>();
		}
		
		[Test]
		public void should_Handle_request_when_content_type_requested_contains_Xml()
		{
			Headers.Add("Accept", "text/xml");

			var handler = new XmlHandler();
			handler.CanHandle(HttpContext).ShouldBeTrue();
		}

		[Test]
		public void should_not_handle_request_when_content_type_requested_does_not_contain_Xml()
		{
			Headers.Add("Accept", "application/json");

			var handler = new XmlHandler();
			handler.CanHandle(HttpContext).ShouldBeFalse();
		}
	}
}