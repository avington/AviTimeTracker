using AutoMapper;
using AviTimeTracker.Core.Entities;
using AviTimeTracker.Core.ViewModels;

namespace AviTimeTracker.Core.MapperProfiles
{
    public class UserProfile : Profile
    {

        public const string ViewModel = "UserPrfile";

        public override string ProfileName
        {
            get
            {
                {
                    return ViewModel;
                }
            }
        }

        protected override void Configure()
        {
            CreateMap<User, UserViewModel>()
                ;
            CreateMap<UserViewModel, User>()
                .ForMember(dest => dest.ProjectMembers,opt => opt.Ignore());
        }
    }
}