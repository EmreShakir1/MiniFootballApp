using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static MiniFootballApp.Areas.Admin.Constants.AdminConstants;

namespace MiniFootballApp.Areas.Admin.Controllers
{
    [Area(AdminArea)]
    [Route("/Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = AdminRole)]
    public class AdminController : Controller
    {
    }
}
