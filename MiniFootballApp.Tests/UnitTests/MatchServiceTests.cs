﻿using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Match;
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
    public class MatchServiceTests : UnitTestsBase
    {
        private IMatchService matchService;

        [OneTimeSetUp]
        public void SetUp() => matchService = new MatchService(repository);

        [Test]
        public async Task CreateMatchAsync_ShouldAddCorrectly()
        {
            var model = new MatchFormModel()
            {
                HomeTeamId = 1,
                AwayTeamId = 2,
                RefereeName = "Test",
                StadiumId = 1,
                StartingDate = DateTime.Now
            };

            var count = context.Matches.Count();

            await matchService.CreateMatchAsync(model);

            var countAfter = context.Matches.Count();

            Assert.That(count + 1, Is.EqualTo(countAfter));
        }

        [Test]
        public async Task AllMatchesAsync_ShouldReturnCorrectValuesWithOldestSorting()
        {
            var count = context.Matches.Count();    

            var model = new AllMatchesQueryModel()
            {
                CurrentPage = 1,
                MatchSorting = Core.Enums.MatchSorting.Oldest,
                SearchTerm = "",
                TotalMatchesCount = 2,
            };

            var result = await matchService.AllMatchesAsync(model);

            Assert.That(count, Is.EqualTo(result.matches.Count()));
            Assert.That(count, Is.EqualTo(result.TotalMatchesCount));
        }

        [Test]
        public async Task AllMatchesAsync_ShouldReturnCorrectValuesWithNewestSorting()
        {
            var count = context.Matches.Count();

            var model = new AllMatchesQueryModel()
            {
                CurrentPage = 1,
                MatchSorting = Core.Enums.MatchSorting.Newest,
                SearchTerm = "",
                TotalMatchesCount = 2,
            };

            var result = await matchService.AllMatchesAsync(model);

            var match = result.matches.FirstOrDefault();
            var homeTeamName = match.HomeTeamName;

            Assert.That(count, Is.EqualTo(result.matches.Count()));
            Assert.That(count, Is.EqualTo(result.TotalMatchesCount));
            Assert.That(Team.Name, Is.EqualTo(homeTeamName));
        }

        [Test]
        public async Task EditAsync_ShouldEditCorrectlyFalse()
        {
            var model = new MatchFormModel()
            {
                RefereeName = "Test",
                IsPlayed = "false",
                Result = "1:0",
            };

            await matchService.EditAsync(Match.Id, model);  

            Assert.That(model.IsPlayed, Is.EqualTo(model.IsPlayed));
            Assert.That(model.Result, Is.EqualTo(model.Result));
            Assert.True(!Match.IsPlayed);
        }

        [Test]
        public async Task EditAsync_ShouldEditCorrectlyTrue()
        {
            var model = new MatchFormModel()
            {
                RefereeName = "Test",
                IsPlayed = "true",
                Result = "1:0",
            };

            await matchService.EditAsync(Match.Id, model);

            Assert.That(model.IsPlayed, Is.EqualTo(model.IsPlayed));
            Assert.That(model.Result, Is.EqualTo(model.Result));
            Assert.True(Match.IsPlayed);
        }

        [Test]
        public async Task FindMatchById_ShouldReturnCorectly()
        {
            var result = await matchService.FindMatchById(Match.Id);

            Assert.That(Match.Result,Is.EqualTo(result.Result));
        }

        [Test]
        public async Task FindMatchById_ShouldReturnCorectlyNull()
        {
            var result = await matchService.FindMatchById(0);

            Assert.IsNull(result);
        }

        [Test]
        public async Task MatchExists_ReturnsCorrectly()
        {
            var result = await matchService.MatchExistsAsync(Match.Id);

            Assert.True(result);
        }
    }
}
