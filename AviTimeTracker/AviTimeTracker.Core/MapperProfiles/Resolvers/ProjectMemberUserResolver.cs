using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectMemberUserResolver : ValueResolver<ProjectMemberViewModel, User>
    {
        protected override User ResolveCore(ProjectMemberViewModel source)
        {
            if (source == null) return null;
            return new User
                       {
                           Id = source.UserId,
                           Name = source.UserName,
                           Email = source.UserEmail
                       };
        }
    }
}