using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiniFootballApp.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
