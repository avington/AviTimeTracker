using System;

namespace AviTimeTracker.Core.ViewModels
{
    public class ProjectMemberViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int  UserId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}