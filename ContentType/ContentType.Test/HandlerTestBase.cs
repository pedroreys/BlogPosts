using System.Collections.Specialized;
using System.Web;
using NUnit.Framework;
using Rhino.Mocks;

namespace ContentType.Test
{
	[TestFixture]
	public class HandlerTestBase : TestBase
	{
		public HttpContextBase HttpContext { get; set;}
		public HttpRequestBase HttpRequest { get; set;}
		public NameValueCollection Headers { get; set;}
		
		[SetUp]
		public void SetUp()
		{
			HttpContext = Stub<HttpContextBase>();
			HttpRequest = Stub<HttpRequestBase>();
			HttpContext.Stub(x => x.Request).Return(HttpRequest);
			Headers = new NameValueCollection();
			HttpRequest.Stub(x => x.Headers).Return(Headers);
		}

	}
}