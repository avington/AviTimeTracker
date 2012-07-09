using System;

namespace AviTimeTracker.Core.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ProjectColor Color { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}