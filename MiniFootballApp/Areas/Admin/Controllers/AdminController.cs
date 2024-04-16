using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiniFootballApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/[controller]/[action]/{id>}")]
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
