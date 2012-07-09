using System;

namespace AviTimeTracker.Core.ViewModels
{
    public class ActivityTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int ColorId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}