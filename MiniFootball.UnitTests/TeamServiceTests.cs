using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootball.UnitTests
{
    [TestFixture]
    public class TeamServiceTests
    {
        private IRepository repo;
        private ITeamService teamService;
        private MiniFootballDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<MiniFootballDbContext>()
                .UseInMemoryDatabase("MiniFootballDb")
                .Options;

            dbContext = new MiniFootballDbContext(contextOptions);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestFindByIdTeamAsync()
        {
            var repo = new Repository(dbContext);
            teamService = new TeamService(repo);

            await repo.AddAsync(new Team()
            {
                Id = 1,
                Name = "Test",
                LogoUrl = "",
                IsApproved = false,
            }
            );

            await repo.SaveChangesAsync();

            var team = await teamService.FindTeamByIdAsync(1);

            Assert.That(1 ,Is.EqualTo(team.Id));
            Assert.That("Test", Is.EqualTo(team.Name));
            Assert.That("", Is.EqualTo(team.LogoUrl));
        }


        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }
    }
}
