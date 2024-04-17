using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
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
    public class TeamServiceTests : UnitTestsBase
    {
        private ITeamService teamService;
        private IRepository repository;

        [OneTimeSetUp]
        public void SetUp()
        {
            var repo = new Repository(context);
            teamService = new TeamService(repo);
        }

        [Test]
        public async Task AllTeamsAsync_ReturnsOnlyApprovedTeams()
        {
            var teams = new List<Team>
            {
                new Team { Id = 1, Name = "Team A", IsApproved = true },
                new Team { Id = 2, Name = "Team B", IsApproved = false }
            }.AsQueryable();

            // Act
            var result = await teamService.AllTeamsAsync();

            // Assert
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result.First().Name, Is.EqualTo("Team A"));
        }
    }
}
