using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class JournalEntryActivityTypeResolver : ValueResolver<JournalEntryViewModel,ActivityType>
    {
        protected override ActivityType ResolveCore(JournalEntryViewModel source)
        {
            if (source == null) return null;
            return new ActivityType
                       {
                           Id = source.Id,
                           Name = source.ActivityTypeName
                       };
        }
    }
}