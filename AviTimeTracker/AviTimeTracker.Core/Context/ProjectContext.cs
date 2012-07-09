using System.Data.Entity;
using AviTimeTracker.Core.Context.Configurations;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
        }

        public ProjectContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectColor> ProjectColors { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActivityTypeConfiguration());
            modelBuilder.Configurations.Add(new JournalEntriesConfiguration());
            modelBuilder.Configurations.Add(new ProjectsConfiguration());
            modelBuilder.Configurations.Add(new ProjectColorsConfiguration());
            modelBuilder.Configurations.Add(new ProjectMembersConfiguration());
            modelBuilder.Configurations.Add(new ProjectTasksConfiguration());
            modelBuilder.Configurations.Add(new TaskTypesConfiguration());
            modelBuilder.Configurations.Add(new UsersConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}