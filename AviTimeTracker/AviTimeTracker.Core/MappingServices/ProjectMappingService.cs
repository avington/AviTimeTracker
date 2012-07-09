using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MappingServices
{
    public class ProjectMappingService : IProjectMappingService
    {
        #region IProjectMappingService Members

        public List<ProjectViewModel> MapToView(IEnumerable<Project> projects)
        {
            return projects == null ? null : projects.Select(Mapper.Map<Project, ProjectViewModel>).ToList();
        }

        #endregion
    }
}