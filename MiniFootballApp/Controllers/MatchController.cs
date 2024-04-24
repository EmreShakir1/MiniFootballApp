using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Match;

namespace MiniFootballApp.Controllers
{
    public class MatchController : BaseController
    {
        private readonly IMatchService matchService;

        public MatchController(IMatchService _matchService)
        {
            matchService = _matchService;
        }

        public async Task<IActionResult> All([FromQuery]AllMatchesQueryModel query)
        {
            var model = await matchService.AllMatchesAsync(query);

            query.TotalMatchesCount = model.TotalMatchesCount;
            query.Matches = model.matches;

            return View(query);
        }
    }
}
