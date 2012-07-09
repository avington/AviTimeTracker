using System;

namespace AviTimeTracker.Core.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string OpenId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}