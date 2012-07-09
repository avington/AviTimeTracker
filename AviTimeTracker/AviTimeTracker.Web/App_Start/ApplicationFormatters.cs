using System.Web.Http;
using AviTimeTracker.Core.Formatters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AviTimeTracker.Web.App_Start
{
    public class ApplicationFormatters
    {
        public static void Initialize()
        {
            var formatters = GlobalConfiguration.Configuration.Formatters;

            //remove the current formatters
            formatters.Remove(formatters.XmlFormatter);
            formatters.Remove(formatters.JsonFormatter);

            //add the json.net formatter
            var serializeSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects };
            serializeSettings.Converters.Add(new IsoDateTimeConverter());
            formatters.Add(new JsonNetFormatter(serializeSettings));
        }
    }
}