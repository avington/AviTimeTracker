using System;
using System.Collections.Generic;

namespace AviTimeTracker.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartedAt { get; set; }
        public virtual ProjectColor Color { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}