using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectColorResolver : ValueResolver<ProjectViewModel, ProjectColor>
    {
        protected override ProjectColor ResolveCore(ProjectViewModel source)
        {
            if (source == null) return null;
            return new ProjectColor
                       {
                           Color = source.Color,
                           Id = source.ColorId
                       };
        }
    }
}