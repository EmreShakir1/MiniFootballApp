using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly IRepository repository;

        public TeamService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<PlayerTeamServiceModel>> AllTeamsAsync()
        {
            return await repository.AllReadOnly<Team>()
                .Where(t=>t.IsApproved == true)
                .Select(t => new PlayerTeamServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TeamServiceModel>> AllTeamsServiceModelAsync()
        {
            return await repository.AllReadOnly<Team>().Where(t=>t.IsApproved == true)
                .Select(t=> new TeamServiceModel 
                { 
                    Id=t.Id,
                    LogoUrl = t.LogoUrl,
                    Name = t.Name,
                    CapitanName = $"{t.Captain.ApplicaitonUser.FirstName} {t.Captain.ApplicaitonUser.LastName}"
                })
                .ToListAsync();
        }

        public async Task CreateTeamAsync(TeamFormModel model, string userId)
        {
            var capitan = await repository.AllReadOnly<Player>().Where(p=>p.UserId == userId).FirstAsync();

            var team = new Team()
            {
                Name = model.Name,
                LogoUrl = model.LogoUrl,
                IsApproved = true,
                CaptainId = capitan.Id,
            };

            await repository.AddAsync(team);
            await repository.SaveChangesAsync();
        }

        public async Task<TeamDetailsServiceModel> FindTeamByIdAsync(int id)
        {
            return await repository.AllReadOnly<Team>().Where(t=>t.Id == id)
                .Select(t=> new TeamDetailsServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    LogoUrl= t.LogoUrl,
                    CapitanName = $"{t.Captain.ApplicaitonUser.FirstName} {t.Captain.ApplicaitonUser.LastName}",
                })
                .FirstAsync();
        }

        public async Task<bool> TeamExistsAsync(int id)
        {
            return await repository.AllReadOnly<Team>().AnyAsync(t=>t.Id == id);
        }
    }
}
