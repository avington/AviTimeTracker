using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context.Configurations
{
    public class ProjectTasksConfiguration: EntityTypeConfiguration<ProjectTask>
    {
        public ProjectTasksConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.Name).IsRequired();
        }
    }
}