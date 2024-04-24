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
                .Where(t => t.IsApproved == true)
                .Select(t => new PlayerTeamServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<TeamServiceModel>> AllTeamsServiceModelAsync()
        {
            return await repository.AllReadOnly<Team>().Where(t => t.IsApproved == true)
                .Select(t => new TeamServiceModel
                {
                    Id = t.Id,
                    LogoUrl = t.LogoUrl,
                    Name = t.Name,
                    CapitanName = $"{t.Captain.ApplicaitonUser.FirstName} {t.Captain.ApplicaitonUser.LastName}"
                })
                .ToListAsync();
        }

        public async Task ApproveATeam(int teamId)
        {
            var team = await repository.GetByIdAsync<Team>(teamId);

            if (team != null)
            {
                team.IsApproved = true;

                await repository.SaveChangesAsync();
            }
        }

        public async Task CreateTeamAsync(TeamFormModel model, string userId)
        {
            var capitan = await repository.AllReadOnly<Player>().Where(p => p.UserId == userId).FirstAsync();

            var team = new Team()
            {
                Name = model.Name,
                LogoUrl = model.LogoUrl,
                IsApproved = false,
                CaptainId = capitan.Id,
            };

            await repository.AddAsync(team);
            await repository.SaveChangesAsync();
            await EditPlayerTeamId(capitan.Id, team.Id);
        }

        public async Task DeleteAsync(int teamId)
        {
            await repository.DeleteAsync<Team>(teamId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int teamId, TeamFormModel model)
        {
            var teamFromDb = await repository.GetByIdAsync<Team>(teamId);

            if (teamFromDb != null)
            {
                teamFromDb.Name = model.Name;
                teamFromDb.LogoUrl = model.LogoUrl;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<TeamDetailsServiceModel> FindTeamByIdAsync(int id)
        {
            return await repository.AllReadOnly<Team>().Where(t => t.Id == id)
                .Select(t => new TeamDetailsServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    LogoUrl = t.LogoUrl,
                    CapitanName = $"{t.Captain.ApplicaitonUser.FirstName} {t.Captain.ApplicaitonUser.LastName}",
                })
                .FirstAsync();
        }

        public async Task<IEnumerable<TeamServiceModel>> GetAllUnApprovedTeams()
        {
            return await repository.All<Team>().Where(t => t.IsApproved == false)
                .Select(t => new TeamServiceModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    LogoUrl = t.LogoUrl,
                    CapitanName = $"{t.Captain.ApplicaitonUser.FirstName} {t.Captain.ApplicaitonUser.LastName}",
                })
                .ToListAsync();
        }

        public async Task<TeamDetailsServiceModel> GetTeamDetailsServiceModelAsync(int teamId)
        {
            var team = await repository.GetByIdAsync<Team>(teamId);

            if (team == null)
            {
                return null;
            }

            var capitan = await repository.GetByIdAsync<Player>(team.CaptainId);
            var user = await repository.GetByIdAsync<ApplicationUser>(capitan.UserId);

            var model = new TeamDetailsServiceModel()
            {
                Id = team.Id,
                CapitanName = $"{user.FirstName} {user.LastName}",
                LogoUrl = team.LogoUrl,
                Name = team.Name,
            };

            return model;
        }



        public async Task<TeamFormModel> GetTeamFormModelAsync(int teamId)
        {
            var team = await repository.GetByIdAsync<Team>(teamId);

            if (team == null)
            {
                return null;
            }

            var model = new TeamFormModel()
            {
                Name = team.Name,
                LogoUrl = team.LogoUrl,
            };

            return model;
        }

        public async Task<bool> TeamExistsAsync(int id)
        {
            return await repository.AllReadOnly<Team>().AnyAsync(t => t.Id == id);
        }

        public async Task<bool> TeamHasForCaptain(int teamId, string UserId)
        {
            var team = await repository.AllReadOnly<Team>().Where(t => t.Id == teamId).FirstOrDefaultAsync();

            var captain = await repository.AllReadOnly<Player>()
                .Where(p => p.UserId == UserId).FirstOrDefaultAsync();

            if (team == null || captain == null)
            {
                return false;
            }

            if (team.CaptainId == captain.Id)
            {
                return true;
            }

            return false;
        }

        private async Task EditPlayerTeamId(int playerId, int teamId)
        {
            var player = await repository.GetByIdAsync<Player>(playerId);

            if (player != null)
            {
                player.TeamId = teamId;

                await repository.SaveChangesAsync();
            }
        }
    }
}
