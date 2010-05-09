using System.Web.Mvc;
using ContentType.ContentTypeHandlers;
using NUnit.Framework;
using Should.Extensions.AssertExtensions;

namespace ContentType.Test
{
	[TestFixture]
	public class HtmlHandlerTest : HandlerTestBase
	{
		[Test]
		public void should_return_a_ViewResult()
		{
			var handler = new HtmlHandler();
			var result = handler.ResultWith("whatever");
			result.ShouldBeType<ViewResult>();
		}

		[Test]
		public void should_Handle_request_when_content_type_requested_contains_html()
		{
			Headers.Add("Accept", "text/html");

			var handler = new HtmlHandler();
			handler.CanHandle(HttpContext).ShouldBeTrue();
		}

		[Test]
		public void should_not_handle_request_when_content_type_requested_does_not_contain_html()
		{
			Headers.Add("Accept", "application/json");

			var handler = new HtmlHandler();
			handler.CanHandle(HttpContext).ShouldBeFalse();
		}
	}
}