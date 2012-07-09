using StructureMap;

namespace AviTimeTracker.Web.App_Start
{
    public class IofC
    {
        public static void Initialize()
        {
            ObjectFactory.Initialize(x =>x.AddRegistry(new StructureMapRegistry()));
        }
    }
}