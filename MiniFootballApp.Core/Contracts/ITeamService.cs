using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Contracts
{
    public interface ITeamService
    {
        Task<IEnumerable<PlayerTeamServiceModel>> AllTeamsAsync();

        Task<bool> TeamExistsAsync(int id);

        Task CreateTeamAsync(TeamFormModel model, string userId);

        Task<IEnumerable<TeamServiceModel>> AllTeamsServiceModelAsync();

        Task<TeamDetailsServiceModel> FindTeamByIdAsync(int id);
    }
}
