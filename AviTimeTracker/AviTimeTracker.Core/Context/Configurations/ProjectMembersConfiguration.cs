using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context.Configurations
{
    public class ProjectMembersConfiguration: EntityTypeConfiguration<ProjectMember>
    {
        public ProjectMembersConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedAt).IsRequired();
        }
    }
}