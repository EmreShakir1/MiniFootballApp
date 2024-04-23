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
    }
}
