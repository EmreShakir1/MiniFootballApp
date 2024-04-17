using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using MiniFootballApp.Infrastucture.Migrations;
using MiniFootballApp.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected MiniFootballDbContext context;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instsance;
            SeedDatabase();
        }

        public ApplicationUser User { get; set; }

        public Player Player { get; set; }

        public Team Team { get; set; }

        public Stadium Stadium { get; set; }

        public Location Location { get; set; }

        private void SeedDatabase()
        {
            User = new ApplicationUser()
            {
                Id = "UserId",
                Email = "user@mail.com",
                FirstName = "Test",
                LastName = "Test"
            };

            Player = new Player()
            {
                Id = 1,
                ApplicaitonUser = User,
                KitNumber = 1,
                Position = Infrastucture.Data.Enumerations.Position.Forward,
                UserId = User.Id,
                Team = Team
            };

            Team = new Team()
            {
                Id = 1,
                Name = "TestTeam",
                LogoUrl = "",
                Captain = Player,
                CaptainId = Player.Id,
                IsApproved = true,
            };

            Location = new Location() 
            {
                Id = 1,
                Address = "bul Bulgaria 10",
                Country = "Bulgaria",
            };

            Stadium = new Stadium()
            {
                Id = 1,
                Capacity = 100,
                Location = Location,
                LocationId = Location.Id,
                Name = "TestStadium",
            };
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
