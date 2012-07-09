using System.Collections.Generic;

namespace AviTimeTracker.Core.ViewModels
{
    public class ProjectSummaryViewModel
    {
        public List<ProjectViewModel> Items { get; set; }
        public int TotalItems { get; set; }
        public string Status { get; set; }
    }
}