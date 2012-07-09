using System.Collections.Generic;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.Services
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAllProjects();
    }
}