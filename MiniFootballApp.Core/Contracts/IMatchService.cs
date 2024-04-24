using MiniFootballApp.Core.Models.Match;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Contracts
{
    public interface IMatchService
    {
        Task CreateMatchAsync(MatchFormModel model);

        Task<MatchQueryServiceModel> AllMatchesAsync(AllMatchesQueryModel model);

        Task<bool> MatchExistsAsync(int id);

        Task<MatchFormModel> FindMatchById(int id);

        Task EditAsync(int id,MatchFormModel model);
    }
}
