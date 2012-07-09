using System.Configuration;
using System.Data.Entity;
using AviTimeTracker.Core.Context;

namespace AviTimeTracker.Web.App_Start
{
    public class ApplicationDatabase
    {
        public static void Initialize()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Database.DefaultConnectionFactory.CreateConnection(connectionString);
            Database.SetInitializer(new AviTimeTrackerInitializer());
            var ctx = new ProjectContext(connectionString);
            ctx.Database.Initialize(true);
        }
    }
}