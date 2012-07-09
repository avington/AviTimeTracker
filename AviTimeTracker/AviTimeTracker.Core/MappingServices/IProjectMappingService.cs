using System.Collections.Generic;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MappingServices
{
    public interface IProjectMappingService
    {
        List<ProjectViewModel> MapToView(IEnumerable<Project> projects);
    }
}