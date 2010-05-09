using ContentType.ContentTypeHandlers;
using NUnit.Framework;
using Should.Extensions.AssertExtensions;

namespace ContentType.Test
{
	[TestFixture]
	public class NotAcceptedContentTypeHandlerTest : HandlerTestBase
	{
		[Test]
		public void should_return_a_NotAcceptedTypeResult()
		{
			var handler = new NotAcceptedContentTypeHandler();
			var result = handler.ResultWith("whatever");
			result.ShouldBeType<NotAcceptedContentTypeResult>();
		}
	}
}