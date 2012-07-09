using System.Collections.Generic;
using System.Web.Http;
using AviTimeTracker.Core.Services;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Web.Controllers
{
    public class ProjectsController : ApiController
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET /api/projects
        public List<ProjectViewModel> Get()
        {
            List<ProjectViewModel> result = _projectService.GetAllProjects();
            return result;
        }

        // GET /api/projects/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/projects
        public void Post(string value)
        {
        }

        // PUT /api/projects/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/projects/5
        public void Delete(int id)
        {
        }
    }
}