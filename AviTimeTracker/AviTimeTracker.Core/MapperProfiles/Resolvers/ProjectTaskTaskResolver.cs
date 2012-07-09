using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles.Resolvers
{
    public class ProjectTaskTaskResolver : ValueResolver<ProjectTaskViewModel,TaskType>
    {
        protected override TaskType ResolveCore(ProjectTaskViewModel source)
        {
            if (source == null) return null;
            return new TaskType
                       {
                           Id = source.TaskTypeId,
                           Name = source.TaskTypeName
                       };
        }
    }
}