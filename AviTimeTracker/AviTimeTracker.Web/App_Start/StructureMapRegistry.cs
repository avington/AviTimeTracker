using StructureMap.Configuration.DSL;

namespace AviTimeTracker.Web.App_Start
{
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            Scan(x =>
                     {
                         x.Assembly("AviTimeTracker.Core");
                         x.TheCallingAssembly();
                         x.WithDefaultConventions();
                     });
        }
    }
}