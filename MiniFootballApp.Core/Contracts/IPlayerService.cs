using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Infrastucture.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Contracts
{
    public interface IPlayerService
    {
        Task<bool> IsPlayerAsync(string userId);

        Task BecomePlayerAsync(string userId, BecomePlayerFormModel model);

        Task<bool> PlayerIsCaptainAsync(string userId);

        Task<IEnumerable<TeamPlayerServiceModel>> GetAllPlayersOfTeamAsync(int teamId);

        Task<bool> PlayerIsInTeamAsync(string userId);

        Task JoinATeamAsync(string userId, int teamId);

        Task<int> FindTeamIdPlayingForAsync(string userId);

    }
}
