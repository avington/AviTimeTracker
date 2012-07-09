using System;
using AviTimeTracker.Core.Context;
using AviTimeTracker.Core.Entities;

namespace AviTimeTracker.Core.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private ProjectContext  _context = new ProjectContext();
        private GenericRepository<ActivityType> _activityTypeRespository;
        private GenericRepository<Project> _projectRespository;
        private GenericRepository<ProjectColor> _projectColorRepository;
        private GenericRepository<ProjectMember> _projectMemberRepository;
        private GenericRepository<ProjectTask> _projectTaskRepository;
        private GenericRepository<TaskType> _taskTypeRespository;
        private GenericRepository<User> _userRepository;

        public GenericRepository<ActivityType> ActivityRepository
        {
            get
            {
                return _activityTypeRespository ?? new GenericRepository<ActivityType>(_context);
            }
        }
        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                return _projectRespository ?? new GenericRepository<Project>(_context);
            }
        }
        public GenericRepository<ProjectColor> ProjectColorRespository
        {
            get
            {
                return _projectColorRepository ?? new GenericRepository<ProjectColor>(_context);
            }
        }
        public GenericRepository<ProjectMember> ProjectMemberRespository
        {
            get
            {
                return _projectMemberRepository ?? new GenericRepository<ProjectMember>(_context);
            }
        }
        public GenericRepository<ProjectTask> ProjectTaskRepository
        {
            get
            {
                return _projectTaskRepository ?? new GenericRepository<ProjectTask>(_context);
            }
        }
        public GenericRepository<TaskType> TaskTypeRespository
        {
            get
            {
                return _taskTypeRespository ?? new GenericRepository<TaskType>(_context);
            }
        }
        public GenericRepository<User> UserRepository
        {
            get
            {
                return _userRepository ?? new GenericRepository<User>(_context);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}