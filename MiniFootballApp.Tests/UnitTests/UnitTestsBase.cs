using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.Common;
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
        protected IRepository repository;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instsance;
            repository = new Repository(context);
            SeedDatabase();
        }

        public ApplicationUser User { get; set; }

        public Player Player { get; set; }

        public ApplicationUser User2 { get; set; }

        public Player Player2 { get; set; }

        public Team Team { get; set; }

        public Stadium Stadium { get; set; }

        public Location Location { get; set; }

        public Match Match { get; set; }

        private void SeedDatabase()
        {
            User = new ApplicationUser()
            {
                Id = "UserId",
                Email = "user@mail.com",
                FirstName = "Test",
                LastName = "Test"
            };
            context.Users.Add(User);

            User2 = new ApplicationUser()
            {
                Id = "UserId2",
                Email = "user2@mail.com",
                FirstName = "Test2",
                LastName = "Test2"
            };
            context.Users.Add(User2);

            Team = new Team()
            {
                Id = 1,
                Name = "TestTeam",
                LogoUrl = "",
                CaptainId = 1,
                IsApproved = false,
            };
            context.Teams.Add(Team);

            Player = new Player()
            {
                Id = 1,
                KitNumber = 1,
                Position = Infrastucture.Data.Enumerations.Position.Forward,
                UserId = User.Id,
                ApplicaitonUser = User,
                Team = Team
            };
            context.Players.Add(Player);

            Player2 = new Player()
            {
                Id = 2,
                KitNumber = 99,
                Position = Infrastucture.Data.Enumerations.Position.Midfielder,
                UserId = User2.Id,
                ApplicaitonUser = User2,
                Team = Team
            };
            context.Players.Add(Player2);


            Location = new Location() 
            {
                Id = 1,
                Address = "bul Bulgaria 10",
                Country = "Bulgaria",
            };
            context.Locations.Add(Location);

            Stadium = new Stadium()
            {
                Id = 1,
                Name = "TestStadium",
                Capacity = 100,
                LocationId = 1,
                Location = Location,
            };
            context.Stadiums.Add(Stadium);

            Match = new Match()
            {
                AwayTeam = Team,
                AwayTeamId = 1,
                HomeTeam = Team,
                HomeTeamId = 1,
                Id = 1,
                IsPlayed = true,
                RefereeName = "TestReferee",
                Result = "1:0",
                StadiumId = 1,
                Stadium = Stadium,
                StartingTime = DateTime.Now,
            };
            context.Matches.Add(Match);

            context.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase() => context.Dispose();
    }
}
