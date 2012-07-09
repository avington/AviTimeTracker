using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class ProjectTaskProfile : Profile
    {

        private const string ViewName = "Project Task";
        public override string ProfileName
        {
            get { return ViewName; }
        }

        protected override void Configure()
        {
            CreateMap<ProjectTask, ProjectTaskViewModel>()
                .ForMember(dest => dest.JournalEntries, opt => opt.ResolveUsing<ProjectTaskJournalEntriesResolver>())
                .ForMember(dest => dest.TaskTypeId, opt => opt.MapFrom(x => x.TaskType.Id))
                .ForMember(dest => dest.TaskTypeName, opt => opt.MapFrom(x => x.TaskType.Name))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(x => x.Color.Color))
                .ForMember(dest => dest.ColorId, opt => opt.MapFrom(x => x.Color.Id));

            CreateMap<ProjectTaskViewModel, ProjectTask>()
                .ForMember(dest  => dest.Project, opt => opt.Ignore())
                .ForMember(dest => dest.JournalEntries, opt =>  opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.TaskType, opt => opt.ResolveUsing<ProjectTaskTaskResolver>())
                .ForMember(dest => dest.Color, opt => opt.ResolveUsing<ProjectTaskColorResolver>());
        }
    }
}