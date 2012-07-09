using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class ActivityTypeProfile : Profile
    {
        private const string ViewName = "Activity Type";
        public override string ProfileName
        {
            get { return ViewName; }
        }

        protected override void Configure()
        {
            CreateMap<ActivityType, ActivityTypeViewModel>()
                .ForMember(dest => dest.Color, opt => opt.MapFrom(x => x.Color.Color))
                .ForMember(dest => dest.ColorId, opt => opt.MapFrom(x => x.Color.Id));

            CreateMap<ActivityTypeViewModel, ActivityType>()
                .ForMember(dest => dest.Color,opt => opt.ResolveUsing<ActivityTypeColorEntityResolver>());
        }
    }
}