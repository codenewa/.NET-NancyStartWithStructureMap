using StructureMap;
using StructureMap.Graph;

namespace NancyStart.Modules
{
    public class StructureMapContainer
    {
        public static void Configure(IContainer container)
        {
            container.Configure(config =>
                config.Scan(c =>
                {
                    c.TheCallingAssembly();
                    c.WithDefaultConventions();
                }));
        }
    }
}