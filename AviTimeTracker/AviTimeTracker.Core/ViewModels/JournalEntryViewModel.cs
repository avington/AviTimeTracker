using System;

namespace AviTimeTracker.Core.ViewModels
{
    public class JournalEntryViewModel
    {
        public int Id { get; set; }
        public string ActivityTypeName { get; set; }
        public int ActivityTypeId { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public DateTime StartedAt { get; set; }
        public decimal Hours { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}