using StructureMap;

namespace ContentType.DependencyResolution
{
	public class StructureMapBootstrapper
	{
		public static void Bootstrap()
		{
			ObjectFactory.Initialize(x => x.Scan(y => 
			                         	{
											y.AssemblyContainingType<DependencyRegistry>();
											y.LookForRegistries();
			                         	}));
		}
	}
}