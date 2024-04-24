using Microsoft.AspNetCore.Mvc;
using MiniFootballApp.Core.Contracts;

namespace MiniFootballApp.Areas.Admin.Controllers
{
    public class TeamController : AdminController
    {
        private readonly ITeamService teamService;

        public TeamController(ITeamService _teamService)
        {
            teamService = _teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var teamsToApprove = await teamService.GetAllUnApprovedTeams();

            return View(teamsToApprove);
        }

        [HttpPost]  
        public async Task<IActionResult> Approve(int id)
        {
            await teamService.ApproveATeam(id);

            return RedirectToAction("Panel", "Home", new { area = "Admin" });
        }
    }
}
