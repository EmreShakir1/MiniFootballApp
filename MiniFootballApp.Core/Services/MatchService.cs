using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Match;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Services
{
    public class MatchService : IMatchService
    {
        private readonly IRepository repository;

        public MatchService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateMatchAsync(MatchFormModel model)
        {
            var match = new Match()
            {
                RefereeName = model.RefereeName,
                StartingTime = model.StartingDate,
                HomeTeamId = model.HomeTeamId,
                AwayTeamId = model.AwayTeamId,
                StadiumId = model.StadiumId,
            };

            await repository.AddAsync(match);
            await repository.SaveChangesAsync();
        }
    }
}
