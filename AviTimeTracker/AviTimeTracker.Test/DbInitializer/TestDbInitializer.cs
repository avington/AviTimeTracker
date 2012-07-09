using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using AviTimeTracker.Core.Context;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Test.DbInitializer
{
    public class TestDbInitializer : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            var red = new ProjectColor {Color = "Red"};
            var yellow = new ProjectColor {Color = "Yellow"};
            var green = new ProjectColor {Color = "Green"};
            var user = new User
                           {
                               CreatedAt = DateTime.Now,
                               Email = "test@test.com",
                               Name = "Steve Moseley",
                               OpenId = "abcdefghigklmnopqrstuvxyz"
                           };
            var project = new Project
                              {
                                  Name = "Test Project",
                                  CompanyCode = "ABC",
                                  CompanyName = "Ajax Inc",
                                  CreatedAt = DateTime.Now,
                                  Color = green,
                                  Description = "Description",
                                  StartedAt = DateTime.Today,
                                  Status = "Status",
                                  ProjectTasks = new Collection<ProjectTask>()
                              };
            var projectMember = new ProjectMember
                                    {
                                        CreatedAt = DateTime.Now,
                                        Project = project,
                                        User = user,
                                        Status = "status"
                                    };
            var taskType = new TaskType
                               {
                                   Color = green,
                                   Status = "Good",
                                   Name = "Feature",
                                   Description = "project task",
                                   CreatedAt = DateTime.Now
                               };
            var activityType = new ActivityType
                                   {
                                       Name = "Development",
                                       Color = green,
                                       CreatedAt = DateTime.Now,
                                       Status = "Status",
                                       Description = "activity type description"
                                   };
            var projectTask = new ProjectTask
                                  {
                                      BidHours = 100,
                                      Color = yellow,
                                      Name = "project task 1",
                                      Status = "projecct task status",
                                      Description = "project task description",
                                      CreatedAt = DateTime.Now,
                                      User = user,
                                      Project = project,
                                      TaskType = taskType,
                                      DueOn = DateTime.Today.AddMonths(1),
                                      StartedOn = DateTime.Today.AddMonths(-1),
                                      JournalEntries = new Collection<JournalEntry>()
                                  };
            var journalEntry = new JournalEntry
                                   {
                                       ActivityType = activityType,
                                       CreatedAt = DateTime.Now,
                                       Description = "Description",
                                       Hours = 7.5m,
                                       Status = "status",
                                       StartedAt = DateTime.Today,
                                       User = user
                                   };
            projectTask.JournalEntries.Add(journalEntry);
            project.ProjectTasks.Add(projectTask);
            context.ProjectColors.Add(red);
            context.ProjectColors.Add(yellow);
            context.ProjectColors.Add(green);
            context.Users.Add(user);
            context.Projects.Add(project);
            context.ProjectMembers.Add(projectMember);
            
            base.Seed(context);
        }
    }
}