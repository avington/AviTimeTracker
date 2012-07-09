using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context.Configurations
{
    public class ProjectColorsConfiguration: EntityTypeConfiguration<ProjectColor>
    {
        public ProjectColorsConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Color).IsRequired();
        }
    }
}