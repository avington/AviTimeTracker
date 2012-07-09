using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectTaskColorResolver : ValueResolver<ProjectTaskViewModel,ProjectColor>
    {
        protected override ProjectColor ResolveCore(ProjectTaskViewModel source)
        {
            if (source ==null) return new ProjectColor();
            return new ProjectColor
                       {
                           Id = source.ColorId,
                           Color = source.Color
                       };
        }
    }
}