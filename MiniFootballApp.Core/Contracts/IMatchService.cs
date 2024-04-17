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
    }
}
