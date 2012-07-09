using System;
using System.Collections.Generic;

namespace AviTimeTracker.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string OpenId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProjectMember> ProjectMembers { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}