using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context.Configurations
{
    public class UsersConfiguration : EntityTypeConfiguration<User>
    {
        public UsersConfiguration()
        {
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.Name).IsRequired();
            Property(x => x.Email).IsRequired();
            Property(x => x.OpenId).IsRequired();
        }
    }
}