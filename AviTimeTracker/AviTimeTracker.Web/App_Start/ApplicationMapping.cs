using AutoMapper;
using AviTimeTracker.Core.MapperProfiles;

namespace AviTimeTracker.Web.App_Start
{
    public class ApplicationMapping
    {
        public static void Initialize()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile(new UserProfile());
                x.AddProfile(new ActivityTypeProfile());
                x.AddProfile(new JournalEntryProfile());
                x.AddProfile(new ProjectMemberProfile());
                x.AddProfile(new ProjectProfile());
                x.AddProfile(new ProjectTaskProfile());
            });
        }
    }
}