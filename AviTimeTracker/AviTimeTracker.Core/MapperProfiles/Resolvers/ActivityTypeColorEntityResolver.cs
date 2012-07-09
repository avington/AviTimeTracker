using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ActivityTypeColorEntityResolver : ValueResolver<ActivityTypeViewModel, ProjectColor>
    {
        protected override ProjectColor ResolveCore(ActivityTypeViewModel source)
        {
            return new ProjectColor
                       {
                           Color = source.Color,
                           Id = source.ColorId
                       };
        }
    }
}