using AutoMapper;
using AviTimeTracker.Core.MapperProfiles;
using AviTimeTracker.Core.MapperProfiles.Resolvers;
using NUnit.Framework;

namespace AviTimeTracker.Test
{
    [TestFixture]
    public class MappingTest
    {
        [SetUp]
        public void Setup()
        {
            Mapper.Initialize(x =>
                                  {
                                      x.AddProfile(new UserProfile());
                                      x.AddProfile(new ActivityTypeProfile());
                                      x.AddProfile(new JournalEntryProfile());
                                      x.AddProfile(new ProjectMemberProfile());
                                      x.AddProfile(new ProjectProfile());
                                      x.AddProfile(new ProjectTaskProfile());
                                  });
        }

        [Test]
        public void Should_be_able_to_map_views_to_entities_and_vice_versa()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}