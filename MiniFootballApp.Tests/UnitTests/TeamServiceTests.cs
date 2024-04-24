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
            await teamService.ApproveATeam(Team.Id);

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
            await teamService.ApproveATeam(Team.Id);


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

        [Test]
        public async Task TeamHasForCaptain_ShouldReturnCorrectValue()
        {
            var teamId = Team.Id;
            var playerId = Player.UserId;

            var result = await teamService.TeamHasForCaptain(teamId, playerId);

            Assert.True(result);
        }

        [Test]
        public async Task GetTeamDetailsServiceModel_ReturnsCorrectlyTeam()
        {
            var team = await teamService.GetTeamDetailsServiceModelAsync(Team.Id);

            Assert.That(Team.Id, Is.EqualTo(team.Id));
        }

        [Test]
        public async Task GetTeamDetailsServiceModel_ReturnsCorrectlyTeamNull()
        {
            var team = await teamService.GetTeamDetailsServiceModelAsync(0);

            Assert.IsNull(team);
        }

        [Test]
        public async Task EditAsync_ShouldEditCorrectly()
        {
            var model = new TeamFormModel() { 
                LogoUrl = "Edited",
                Name = "Edited",
            };

            await teamService.EditAsync(Team.Id, model);

            Assert.That(model.Name, Is.EqualTo(Team.Name));
            Assert.That(model.LogoUrl, Is.EqualTo(Team.LogoUrl));
        }

        [Test]
        public async Task ApproveATeam_ShouldApproveATeam()
        {
            await teamService.ApproveATeam(Team.Id);

            Assert.True(Team.IsApproved);
        }

        [Test]
        public async Task GetTeamFormModelAsync_ShouldReturnCorrectTeam()
        {
            var model = await teamService.GetTeamFormModelAsync(Team.Id);

            Assert.That(Team.Name, Is.EqualTo(model.Name));
            Assert.That(Team.LogoUrl, Is.EqualTo(model.LogoUrl));
        }

        [Test]
        public async Task GetTeamFormModelAsync_ShouldReturnCorrectTeamNull()
        {
            var model = await teamService.GetTeamFormModelAsync(0);

            Assert.IsNull(model);
        }

        [Test]
        public async Task TeamHasForCaptain_ShouldReturnCorrectValueFalse1()
        {
            var teamId = Team.Id;
            var playerId = "";

            var result = await teamService.TeamHasForCaptain(teamId, playerId);

            Assert.True(!result);
        }
        [Test]
        public async Task TeamHasForCaptain_ShouldReturnCorrectValueFalse2()
        {
            var teamId = 0;
            var playerId = User.Id;

            var result = await teamService.TeamHasForCaptain(teamId, playerId);

            Assert.True(!result);
        }

        [Test]
        public async Task TeamHasForCaptain_ShouldReturnCorrectValueFalse3()
        {
            var teamId = Team.Id;
            var playerId = User2.Id;

            var result = await teamService.TeamHasForCaptain(teamId, playerId);

            Assert.True(!result);
        }
    }
}
