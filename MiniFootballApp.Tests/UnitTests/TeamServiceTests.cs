using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Tests.UnitTests
{
    [TestFixture]
    public class TeamServiceTests : UnitTestsBase
    {
        private ITeamService teamService;

        [OneTimeSetUp]
        public void SetUp()
        {
            teamService = new TeamService(repository);
        }

        [Test]
        public async Task TeamExistsAsync_ShouldReturnCorrectTeam()
        {
            var result = await teamService.TeamExistsAsync(Team.Id);

            Assert.That(result, Is.EqualTo(true));

        }

        [Test]
        public async Task AllTeamsAsync_ShouldReturnCorrectCount()
        {
            var result = await teamService.AllTeamsAsync();

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task CreateTeamAsync_ShouldCreateTeam()
        {
            var count = context.Teams.Count();

            var teamToAdd = new TeamFormModel() 
            {
                Name = "Test",
                LogoUrl = "aaaaaa",
            };

            await teamService.CreateTeamAsync(teamToAdd, User.Id);

            var countAfter = context.Teams.Count();

            Assert.That(count + 1, Is.EqualTo(countAfter));
            Assert.That(teamToAdd.Name, Is.EqualTo("Test"));
            Assert.That(teamToAdd.LogoUrl, Is.EqualTo("aaaaaa"));
        }

        [Test]
        public async Task AllTeamsServiceModelAsync_ShouldReturnCorrect()
        {
            var result = await teamService.AllTeamsServiceModelAsync();

            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task FindTeamByIdAsync_ShouldReturnCorrectTeam()
        {
            var team = await teamService.FindTeamByIdAsync(1);

            Assert.That(Team.Id, Is.EqualTo(team.Id));
        }

        [Test]
        public async Task TeamExistsAsync_ShoudlReturnCorrectValue()
        {
            var result = await teamService.TeamExistsAsync(1);

            Assert.IsTrue(result);
        }
    }
}
