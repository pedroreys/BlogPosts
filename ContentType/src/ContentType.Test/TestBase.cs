using NUnit.Framework;
using Rhino.Mocks;

namespace ContentType.Test
{
	[TestFixture]
	public abstract class TestBase
	{
		protected static T Stub<T>(params object[] argumentsForConstructor) where T: class
		{
			return MockRepository.GenerateStub<T>(argumentsForConstructor);
		}
	}
}