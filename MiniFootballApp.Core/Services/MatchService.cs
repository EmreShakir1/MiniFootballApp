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
    public class MatchService : IMatchService
    {
        private readonly IRepository repository;

        public MatchService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<MatchQueryServiceModel> AllMatchesAsync(AllMatchesQueryModel model)
        {
            var matchesFromDb = await  repository.AllReadOnly<Match>().ToListAsync();

            if (model.SearchTerm != null)
            {
                string normalizedSearch = model.SearchTerm.ToLower();
                matchesFromDb = matchesFromDb
                    .Where(m => 
                    (GetTeamNameById(m.HomeTeamId).ToLower().Contains(normalizedSearch)) ||
                    (GetTeamNameById(m.AwayTeamId).ToLower().Contains(normalizedSearch)) ||
                    m.RefereeName.ToLower().Contains(normalizedSearch)).ToList();
            }

            if (model.MatchSorting == Enums.MatchSorting.Oldest)
            {
                matchesFromDb.OrderByDescending(m => m.StartingTime);
            }
            else
            {
                matchesFromDb.OrderBy(m => m.StartingTime);
            }

            var matchesToShow = matchesFromDb.Skip((model.CurrentPage - 1) * AllMatchesQueryModel.MatchPerPage)
                .Take(AllMatchesQueryModel.MatchPerPage)
                .Select( m => new MatchServiceModel
                {
                    Id = m.Id,
                    HomeTeamName = GetTeamNameById(m.HomeTeamId),
                    AwayTeamName = GetTeamNameById(m.AwayTeamId),
                    RefereeName = m.RefereeName,
                    Result = m.Result ?? string.Empty,
                    StadiumName = GetStadiumNameById(m.StadiumId),
                    StartingTime = m.StartingTime.ToString("HH:mm dd/MM/yyyy"),
                    IsPlayed = m.IsPlayed,
                }).ToList();

            int totalMatches = matchesFromDb.Count();

            return new MatchQueryServiceModel()
            {
                matches = matchesToShow,
                TotalMatchesCount = totalMatches
            };
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
                IsPlayed = false,
            };

            await repository.AddAsync(match);
            await repository.SaveChangesAsync();
        }

        private string GetTeamNameById(int teamId)
        {
            var team = repository.AllReadOnly<Team>().FirstOrDefault(x => x.Id == teamId);

            return team?.Name ?? string.Empty;
        }

        private string GetStadiumNameById(int stadiumId)
        {
            var stadium = repository.AllReadOnly<Stadium>().FirstOrDefault(x => x.Id == stadiumId);

            return stadium?.Name ?? string.Empty;
        }

        public async Task<bool> MatchExistsAsync(int id)
        {
            return await repository.AllReadOnly<Match>().AnyAsync(m => m.Id == id);    
        }

        public async Task<MatchFormModel> FindMatchById(int id)
        {
            var match = await repository.GetByIdAsync<Match>(id);

            if (match == null)
            {
                return null;
            }

            var model = new MatchFormModel()
            {
                AwayTeamId = match.AwayTeamId,
                HomeTeamId = match.HomeTeamId,
                IsPlayed = match.IsPlayed ? "True" : "False",
                RefereeName = match.RefereeName,
                StartingDate = match.StartingTime,
                Result = match.Result ?? string.Empty,
                StadiumId = match.StadiumId,
            };

            return model;
        }

        public async Task EditAsync(int id,MatchFormModel model)
        {
            var match = await repository.GetByIdAsync<Match>(id);

            if (match != null)
            {
                match.StartingTime = model.StartingDate;
                match.RefereeName = model.RefereeName;
                match.AwayTeamId = model.AwayTeamId;
                match.HomeTeamId = model.HomeTeamId;
                match.Result = model.Result;
                match.StadiumId = model.StadiumId;
                if (model.IsPlayed.ToLower() == "true")
                {
                    match.IsPlayed = true;
                }
                if (model.IsPlayed.ToLower() == "false")
                {
                    match.IsPlayed = false;
                }

                await repository.SaveChangesAsync();    
            }
        }
    }
}
