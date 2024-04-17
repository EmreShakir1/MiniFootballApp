using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;

namespace MiniFootball.UnitTests
{
    [TestFixture]
    public class TeamServiceTests
    {
        private Mock<IRepository> mockRepository;
        private TeamService teamService;

        [SetUp]
        public void SetUp()
        {
            mockRepository = new Mock<IRepository>();
            teamService = new TeamService(mockRepository.Object);
        }

        [Test]
        public async Task AllTeamsAsync_ReturnsOnlyApprovedTeams()
        {
            // Arrange
            var data = new List<Team>
            {
            new Team { Id = 1, Name = "Team A", IsApproved = true },
            new Team { Id = 2, Name = "Team B", IsApproved = false }
            }
                .AsQueryable();

            mockRepository.Setup(r => r.AllReadOnly<Team>()).Returns(data);

            // Act
            var result = await teamService.AllTeamsAsync();

            // Assert
            mockRepository.Verify(r => r.AllReadOnly<Team>(), Times.Once);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Team A", result.First().Name);
        }

        [Test]
        public async Task CreateTeamAsync_CreatesAndSavesTeam()
        {
            // Arrange
            var players = new List<Player>
            {
                new Player { Id = 1, UserId = "user123" }
            }.AsQueryable();

            var model = new TeamFormModel { Name = "New Team", LogoUrl = "url" };

            mockRepository.Setup(r => r.AllReadOnly<Player>()).Returns(players);

            // Act
            await teamService.CreateTeamAsync(model, "user123");

            // Assert
            mockRepository.Verify(r => r.AddAsync(It.IsAny<Team>()), Times.Once);
            mockRepository.Verify(r => r.SaveChangesAsync(), Times.Once);
        }

        [Test]
        public async Task FindTeamByIdAsync_ReturnsCorrectTeam()
        {
            // Arrange
            var data = new List<Team>
            {
                new Team { Id = 1, Name = "Team A", Captain = new Player { ApplicaitonUser = new ApplicationUser { FirstName = "John", LastName = "Doe" } } }
            }.AsQueryable();

            mockRepository.Setup(r => r.AllReadOnly<Team>()).Returns(data);

            // Act
            var result = await teamService.FindTeamByIdAsync(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Team A", result.Name);
            Assert.AreEqual("John Doe", result.CapitanName);
        }

    }
}
