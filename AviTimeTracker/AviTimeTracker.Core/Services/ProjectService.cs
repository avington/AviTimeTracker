using System.Collections.Generic;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MappingServices;
using AviTimeTracker.Core.Repositories;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectMappingService _mappingService;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork, IProjectMappingService mappingService)
        {
            _unitOfWork = unitOfWork;
            _mappingService = mappingService;
        }

        #region IProjectService Members

        public List<ProjectViewModel> GetAllProjects()
        {
            IEnumerable<Project> projects = _unitOfWork.ProjectRepository.Get();
            List<ProjectViewModel> result = _mappingService.MapToView(projects);
            return result;
        }

        #endregion
    }
}