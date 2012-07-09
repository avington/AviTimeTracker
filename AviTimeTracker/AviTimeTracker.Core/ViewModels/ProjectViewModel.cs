using System;
using System.Collections.Generic;

namespace AviTimeTracker.Core.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartedAt { get; set; }
        public string Color { get; set; }
        public int ColorId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<ProjectMemberViewModel> ProjectMembers { get; set; }

        public List<ProjectTaskViewModel> ProjectTasks { get; set; }
    }
}