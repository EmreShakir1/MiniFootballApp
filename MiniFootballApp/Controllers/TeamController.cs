﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Core.Services;
using System.Security.Claims;

namespace MiniFootballApp.Controllers
{
    public class TeamController : BaseController
    {
        private readonly ITeamService teamService;
        private readonly IPlayerService playerService;

        public TeamController(ITeamService _teamService, IPlayerService _playerService)
        {
            teamService = _teamService;   
            playerService = _playerService;

        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            string userId = User.Id();

            if (await playerService.PlayerIsCaptainAsync(userId))
            {
                return BadRequest();
                //A player can be captain to only one team!
            }

            var model = new TeamFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(TeamFormModel model)
        {
            string userId = User.Id();

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await teamService.CreateTeamAsync(model, userId);

            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> All()
        {
            var model = await teamService.AllTeamsServiceModelAsync();

            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            var team = await teamService.FindTeamByIdAsync(id);

            team.Players = await playerService.GetAllPlayersOfTeamAsync(id);

            return View(team);
        }

        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();

            var teamId = await playerService.FindTeamIdPlayingForAsync(userId);

            var team = await teamService.FindTeamByIdAsync(teamId);

            return RedirectToAction(nameof(Details), new {id = teamId});
        }

        public async Task<IActionResult> Join(int id)
        {
            var userId = User.Id();

            if (await playerService.PlayerIsInTeamAsync(userId))
            {
                return BadRequest();
            }

            await playerService.JoinATeamAsync(userId, id);

            return RedirectToAction("Index","Home");
        }


    }
}