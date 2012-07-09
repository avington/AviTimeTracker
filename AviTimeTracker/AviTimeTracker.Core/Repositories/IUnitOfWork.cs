using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Repositories
{
    public interface IUnitOfWork
    {
        GenericRepository<ActivityType> ActivityRepository { get; }
        GenericRepository<Project> ProjectRepository { get; }
        GenericRepository<ProjectColor> ProjectColorRespository { get; }
        GenericRepository<ProjectMember> ProjectMemberRespository { get; }
        GenericRepository<ProjectTask> ProjectTaskRepository { get; }
        GenericRepository<TaskType> TaskTypeRespository { get; }
        GenericRepository<User> UserRepository { get; }
        void Save();
        void Dispose();
    }
}