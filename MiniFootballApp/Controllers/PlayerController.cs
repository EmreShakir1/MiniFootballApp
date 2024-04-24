using Microsoft.AspNetCore.Mvc;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Services;
using System.Security.Claims;

namespace MiniFootballApp.Controllers
{
    public class PlayerController : BaseController
    {
        private readonly ITeamService teamService;
        private readonly IPlayerService playerService;


        public PlayerController(ITeamService _teamService, IPlayerService _playerService)
        {
            teamService = _teamService;
            playerService = _playerService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model = new BecomePlayerFormModel()
            {
                Teams = await teamService.AllTeamsAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomePlayerFormModel model)
        {
            string userId = User.Id();

            if (model.TeamId != null && await teamService.TeamExistsAsync((int)model.TeamId) == false)
            {
                ModelState.AddModelError(nameof(model.TeamId), "The team does not exists");
            }

            if (ModelState.IsValid == false)
            {
                model.Teams = await teamService.AllTeamsAsync();

                return View(model);
            }


            await playerService.BecomePlayerAsync(userId, model);

            if (model.TeamId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Details", "Team", new { id = model.TeamId });
        }

        



    }
}

