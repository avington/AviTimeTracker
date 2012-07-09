using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context.Configurations
{
    public class JournalEntriesConfiguration: EntityTypeConfiguration<JournalEntry>
    {
        public JournalEntriesConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedAt).IsRequired();
        }
    }
}