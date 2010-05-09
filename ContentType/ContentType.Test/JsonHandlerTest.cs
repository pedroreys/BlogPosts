using System.Web.Mvc;
using ContentType.ContentTypeHandlers;
using NUnit.Framework;
using Should.Extensions.AssertExtensions;

namespace ContentType.Test
{
	[TestFixture]
	public class JsonHandlerTest : HandlerTestBase
	{
		[Test]
		public void should_return_a_JsonResult()
		{
			var handler = new JsonHandler();
			var result = handler.ResultWith("whatever");
			result.ShouldBeType<JsonResult>();
		}

		[Test]
		public void should_Handle_request_when_content_type_requested_contains_Json()
		{
			Headers.Add("Accept", "application/json");

			var handler = new JsonHandler();
			handler.CanHandle(HttpContext).ShouldBeTrue();
		}

		[Test]
		public void should_not_handle_request_when_content_type_requested_does_not_contain_json()
		{
			Headers.Add("Accept", "text/xml");

			var handler = new JsonHandler();
			handler.CanHandle(HttpContext).ShouldBeFalse();
		}
	}
}
