using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context
{
    public class ProjectsConfiguration: EntityTypeConfiguration<Project>
    {
        public ProjectsConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.Name).IsRequired();
        }
    }
}