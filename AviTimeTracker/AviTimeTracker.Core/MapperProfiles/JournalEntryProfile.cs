using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class JournalEntryProfile : Profile
    {
        private const string ViewName = "Journal Entry";
        public override string ProfileName
        {
            get { return ViewName; }
        }

        protected override void Configure()
        {
            CreateMap<JournalEntry, JournalEntryViewModel>()
                .ForMember(x => x.ActivityTypeId, opt => opt.MapFrom(x => x.ActivityType.Id))
                .ForMember(x => x.ActivityTypeName, opt => opt.MapFrom(x => x.ActivityType.Name))
                .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.User.Id))
                .ForMember(x => x.UserEmail, opt => opt.MapFrom(x => x.User.Email))
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.Name));

            CreateMap<JournalEntryViewModel, JournalEntry>()
                .ForMember(dest => dest.ActivityType, opt => opt.ResolveUsing<JournalEntryActivityTypeResolver>())
                .ForMember(dest => dest.User, opt => opt.ResolveUsing<JournalEntryUserActivityTypeResolver>());
        }
    }
}