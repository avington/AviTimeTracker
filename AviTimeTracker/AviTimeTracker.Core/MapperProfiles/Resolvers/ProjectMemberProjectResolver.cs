using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectMemberProjectResolver : ValueResolver<ProjectMemberViewModel, Project>
    {
        protected override Project ResolveCore(ProjectMemberViewModel source)
        {
            if (source == null) return null;
            return new Project
                       {
                           Id = source.ProjectId,
                           Name = source.ProjectName
                       };
        }
    }
}