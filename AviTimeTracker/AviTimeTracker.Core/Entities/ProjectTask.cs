using System;
using System.Collections.Generic;

namespace AviTimeTracker.Core.Entities
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual TaskType TaskType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime DueOn { get; set; }
        public decimal BidHours { get; set; }
        public virtual ProjectColor Color { get; set; }
        public string Status { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}