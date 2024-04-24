using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Tests.UnitTests
{
    [TestFixture]
    public class StadiumServiceTests : UnitTestsBase
    {
        private IStadiumService stadiumService;

        [OneTimeSetUp]
        public void SetUp() => stadiumService = new StadiumService(repository);


        [Test]
        public async Task AllStadiumsAsync_ShouldReturnCorrectValue()
        {
            var stadiums = await stadiumService.AllStadiumsAsync();

            Assert.That(1, Is.EqualTo(stadiums.Count()));
        }
    }
}
