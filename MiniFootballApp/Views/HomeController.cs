using Microsoft.AspNetCore.Mvc;
using MiniFootballApp.Areas.Admin.Controllers;

namespace MiniFootballApp.Views
{
    public class HomeController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
