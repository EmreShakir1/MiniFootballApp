using MiniFootballApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Tests.IntegrationTests
{
    [TestFixture]   
    public class HomeControllerTests
    {
        private HomeController homeController;

        [OneTimeSetUp]
        public void Setup() => this.homeController = new HomeController();
        
        [Test]
        public void Error_ShouldReturnCorrectView()
        {
            var statusCode = 500;

            var result = homeController.Error(statusCode);

            Assert.IsNotNull(result);

            var viewResult = result as Microsoft.AspNetCore.Mvc.ViewResult;

            Assert.IsNotNull(viewResult);
        }
    }
}
