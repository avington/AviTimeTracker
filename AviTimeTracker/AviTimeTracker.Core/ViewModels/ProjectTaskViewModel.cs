using System;
using System.Collections.Generic;

namespace AviTimeTracker.Core.ViewModels
{
    public class ProjectTaskViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int UserEmail { get; set; }
        public int TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime DueOn { get; set; }
        public decimal BidHours { get; set; }
        public int ColorId { get; set; }
        public string Color { get; set; }
        public string Status { get; set; }
        public virtual List<JournalEntryViewModel> JournalEntries { get; set; }
        public DateTime CreatedAt { get; set; } 
    }
}