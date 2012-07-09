using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class ProjectProfile : Profile
    {
        private const string ViewName = "Project";
        public override string ProfileName
        {
            get { return ViewName; }
        }

        protected override void Configure()
        {
            CreateMap<Project, ProjectViewModel>()
                .ForMember(dest => dest.ProjectTasks, opt => opt.Ignore())
                .ForMember(dest => dest.Color,opt => opt.MapFrom(x => x.Color.Color))
                .ForMember(dest => dest.ColorId, opt => opt.MapFrom(x => x.Color.Id));

            CreateMap<ProjectViewModel, Project>()
                .ForMember(dest => dest.ProjectMembers, opt => opt.Ignore())
                .ForMember(dest => dest.ProjectTasks, opt => opt.Ignore())
                .ForMember(dest => dest.Color, opt => opt.ResolveUsing<ProjectColorResolver>());
        }
    }
}