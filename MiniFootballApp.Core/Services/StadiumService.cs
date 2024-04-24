using Microsoft.EntityFrameworkCore;
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
    public class StadiumService : IStadiumService
    {
        private readonly IRepository repository;

        public StadiumService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<MatchStadiumServiceModel>> AllStadiumsAsync()
        {
            return await repository.AllReadOnly<Stadium>()
                .Select(s => new MatchStadiumServiceModel
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();
        }
    }
}
