using System;

namespace AviTimeTracker.Core.Entities
{
    public class JournalEntry   
    {
        public int Id { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual User User { get; set; }
        public DateTime StartedAt { get; set; }
        public decimal Hours { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}