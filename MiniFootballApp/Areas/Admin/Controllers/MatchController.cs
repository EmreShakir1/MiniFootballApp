using Microsoft.AspNetCore.Mvc;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Match;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System.Security.Claims;

namespace MiniFootballApp.Areas.Admin.Controllers
{
    public class MatchController : AdminController
    {
        private readonly ITeamService teamService;
        private readonly IMatchService matchService;
        private readonly IStadiumService stadiumService;

        public MatchController(ITeamService _teamService, IMatchService _matchService, IStadiumService _stadiumService)
        {
            teamService = _teamService;
            matchService = _matchService;
            stadiumService = _stadiumService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new MatchFormModel()
            {
                Teams = await teamService.AllTeamsAsync(),
                Stadiums = await stadiumService.AllStadiumsAsync(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(MatchFormModel model)
        {
            if (model.HomeTeamId == model.AwayTeamId)
            {
                ModelState.AddModelError(nameof(model.AwayTeamId), "Away team cannot be same as the home team!");
            }

            if (ModelState.IsValid == false)
            {
                model = new MatchFormModel()
                {
                    Teams = await teamService.AllTeamsAsync(),
                    Stadiums = await stadiumService.AllStadiumsAsync(),
                };

                return View(model);
            }

            await matchService.CreateMatchAsync(model);
            return RedirectToAction("All", "Match", new { area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (await matchService.MatchExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (User.IsAdmin() == false)
            {
                return Unauthorized();  
            }

            var model = await matchService.FindMatchById(id);
            model.Teams = await teamService.AllTeamsAsync();
            model.Stadiums = await stadiumService.AllStadiumsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, MatchFormModel model)
        {
            if (await matchService.MatchExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid == false)
            {
                model = new MatchFormModel()
                {
                    Teams = await teamService.AllTeamsAsync(),
                    Stadiums = await stadiumService.AllStadiumsAsync(),
                };

                return View(model);
            }

            await matchService.EditAsync(id,model);

            return RedirectToAction("Panel", "Home", new { area = "Admin" });
        }
    }
}
