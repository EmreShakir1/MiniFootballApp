using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Tests.UnitTests
{
    [TestFixture]
    public class PlayerServiceTests : UnitTestsBase
    {
        private IPlayerService playerService;

        [OneTimeSetUp]
        public void SetUp() => playerService = new PlayerService(repository);

        [Test]
        public async Task BecomePlayerAsync_ShouldAddPlayer()
        {
            string userId = User.Id;

            var model = new BecomePlayerFormModel()
            {
                KitNumber = 1,
                Position = Position.Midfielder.ToString(),
                TeamId = Team.Id,
            };
            var count = context.Players.Count();

            await playerService.BecomePlayerAsync(userId, model);

            var countAfter = context.Players.Count();

            Assert.That(count + 1, Is.EqualTo(countAfter));
        }

        [Test]
        public async Task FindTeamIdForPlayerAsync_ShouldReturnCorrectId()
        {
            var userId = User.Id;

            var teamId = await playerService.FindTeamIdPlayingForAsync(userId);

            Assert.That(Team.Id, Is.EqualTo(teamId));
        }

        [Test]
        public async Task GetAllPlayersOfATeamAsync_ShouldReturnCorrectly()
        {
            var count = context.Players.Where(x => x.TeamId == Team.Id).Count();

            var result = await playerService.GetAllPlayersOfTeamAsync(Team.Id);

            var countResult = result.Count();

            Assert.That(count, Is.EqualTo(countResult));
        }

        [Test]
        public async Task PlayerIsInTeamAsync_ShouldReturnCorrectValues()
        {
            var result = await playerService.PlayerIsInTeamAsync(User.Id);

            Assert.True(result);
        }

        //[Test]
        //public async Task JoinATeamAsync_ShouldAddPlayer()
        //{
        //    var count = Team.Players.Count();

        //    await playerService.JoinATeamAsync(User2.Id, Team.Id);

        //    Assert.That(count + 1, Is.EqualTo(Team.Players.Count()));
        //}

        [Test]
        public async Task PlayerIsCaptainAsync()
        {
            var result = await playerService.PlayerIsCaptainAsync(User.Id);

            Assert.True(result);
        }

        [Test]
        public async Task IsPlayerAsync()
        {
            var result = await playerService.IsPlayerAsync(User.Id);

            Assert.True(result);
        }
    }
}
