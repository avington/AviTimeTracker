using System;

namespace AviTimeTracker.Core.Entities
{
    public class ProjectMember
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}