using System.Data.Entity;
using System.Linq;
using AviTimeTracker.Core.Context;
using AviTimeTracker.Test.DbInitializer;
using NUnit.Framework;

namespace AviTimeTracker.Test
{
    [TestFixture]
    public class ProjectContextTest
    {
        [SetUp]
        public void Setup()
        {
            Database.DefaultConnectionFactory.CreateConnection(
                "Data Source=(local);Initial Catalog=AviTimeTracker_test;Integrated Security=True");
            Database.SetInitializer(new TestDbInitializer());
        }

        [Test]
        public void Should_be_able_to_read_the_project_table_from_the_database()
        {
            var context = new ProjectContext();
            Assert.IsTrue(context.ProjectColors.Any());
            Assert.IsTrue(context.Projects.Any());
            Assert.IsTrue(context.ProjectMembers.Any());
        }
    }
}