using System;
using System.Data.Entity;
using AviTimeTracker.Core.Context;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Web.App_Start
{
    public class AviTimeTrackerInitializer : CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var green = new ProjectColor {Color = "Green"};
            var yellow = new ProjectColor {Color = "Yellow"};
            var red = new ProjectColor {Color = "Red"};
            context.ProjectColors.Add(green);
            context.ProjectColors.Add(yellow);
            context.ProjectColors.Add(red);
            context.TaskTypes.Add(new TaskType
                                      {
                                          Color = green,
                                          CreatedAt = DateTime.Now,
                                          Name = "Features",
                                          Description = "New features work on a project"
                                      });
            context.TaskTypes.Add(new TaskType
                                      {
                                          Color = green,
                                          CreatedAt = DateTime.Now,
                                          Name = "Maintenance",
                                          Description = "Bug fixes, performance improvements, etc"
                                      });
            context.TaskTypes.Add(new TaskType
                                      {
                                          Color = green,
                                          CreatedAt = DateTime.Now,
                                          Name = "Proposal",
                                          Description = "Initial project proposal"
                                      });
            context.ActivityTypes.Add(new ActivityType {Color = green, CreatedAt = DateTime.Now, Name = "Design"});
            context.ActivityTypes.Add(new ActivityType {Color = green, CreatedAt = DateTime.Now, Name = "Development"});
            context.ActivityTypes.Add(new ActivityType {Color = green, CreatedAt = DateTime.Now, Name = "Debugging"});
            context.ActivityTypes.Add(new ActivityType {Color = green, CreatedAt = DateTime.Now, Name = "Testing"});
            context.ActivityTypes.Add(new ActivityType {Color = green, CreatedAt = DateTime.Now, Name = "Deploying"});

            base.Seed(context);
        }
    }
}