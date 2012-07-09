using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class JournalEntryUserActivityTypeResolver : ValueResolver<JournalEntryViewModel,User>
    {
        protected override User ResolveCore(JournalEntryViewModel source)
        {
            if (source == null) return null;
            return new User
                       {
                           Id = source.UserId,
                           Email = source.UserEmail,
                           Name = source.UserName
                       };
        }
    }
}