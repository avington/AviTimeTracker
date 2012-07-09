using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class ProjectMemberProfile : Profile
    {
        private const string ViewName = "Project Member";
        public override string ProfileName
        {
            get { return ViewName; }
        }

        protected override void Configure()
        {
            CreateMap<ProjectMember, ProjectMemberViewModel>()
                .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.User.Id))
                .ForMember(x => x.UserEmail, opt => opt.MapFrom(x => x.User.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.Name))
                .ForMember(x => x.ProjectId, opt => opt.MapFrom(x => x.Project.Id))
                .ForMember(x => x.ProjectName, opt => opt.MapFrom(x => x.Project.Name))
                ;
            CreateMap<ProjectMemberViewModel, ProjectMember>()
                .ForMember(dest => dest.Project,opt => opt.ResolveUsing<ProjectMemberProjectResolver>())
                .ForMember(dest => dest.User, opt => opt.ResolveUsing<ProjectMemberUserResolver>())
                ;
        }
    }
}