using Microsoft.AspNetCore.Mvc;

namespace MiniFootballApp.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        public IActionResult Panel()
        {
            return View();
        }
    }
}
