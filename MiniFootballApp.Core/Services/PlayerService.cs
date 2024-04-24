using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Models.Player;
using MiniFootballApp.Core.Models.Team;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using MiniFootballApp.Infrastucture.Data.Enumerations;

namespace MiniFootballApp.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IRepository repository;

        public PlayerService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task BecomePlayerAsync(string userId, BecomePlayerFormModel model)
        {
            var player = new Player()
            {
                KitNumber = model.KitNumber,
                Position = (Position)Enum.Parse(typeof(Position),model.Position),
                UserId = userId,
                TeamId = model.TeamId,
            };

            await repository.AddAsync(player);
            await repository.SaveChangesAsync();
        }

        public async Task<int> FindTeamIdPlayingForAsync(string userId)
        {
            var player = await GetPlayerByUserIdAsync(userId);

            if (player.TeamId == null)
            {
                return 0;
            }

            return (int)player.TeamId;
        }

        public async Task<IEnumerable<TeamPlayerServiceModel>> GetAllPlayersOfTeamAsync(int teamId)
        {
            return await repository.AllReadOnly<Player>().Where(p=>p.TeamId == teamId)
                .Select(p=> new TeamPlayerServiceModel()
                {
                    Id = p.Id,
                    KitNumber=p.KitNumber,
                    Name = $"{p.ApplicaitonUser.FirstName} {p.ApplicaitonUser.LastName}",
                    Position = p.Position.ToString(),
                })
                .ToListAsync();
        }

        

        public async Task<bool> IsPlayerAsync(string userId)
        {
            return await repository.AllReadOnly<Player>().AnyAsync(x => x.UserId == userId);
        }

        public async Task JoinATeamAsync(string userId, int teamId)
        {
            var playerToJoin = await GetPlayerByUserIdAsync(userId);

            var team = await repository.All<Team>().Where(t => t.Id == teamId).FirstAsync();

            team.Players.Add(playerToJoin);

            await repository.SaveChangesAsync();
        }

        public async Task<bool> PlayerIsCaptainAsync(string userId)
        {
            var captain = await GetPlayerByUserIdAsync(userId);

            return await repository.AllReadOnly<Team>().AnyAsync(t => t.CaptainId == captain.Id);
        }

        public async Task<bool>    PlayerIsInTeamAsync(string userId)
        {
            var player = await repository.AllReadOnly<Player>().Where(p=>p.UserId == userId).FirstOrDefaultAsync();

            if (player == null || player.TeamId == null)
            {
                return false;
            }

            return true;
        }

        private async Task<Player> GetPlayerByUserIdAsync(string userId)
        {
            var player = await repository.AllReadOnly<Player>().Where(p => p.UserId == userId).FirstAsync();

            return player;
        }
    }
}
