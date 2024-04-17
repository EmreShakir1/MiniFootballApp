using MiniFootballApp.Core.Enums;

namespace MiniFootballApp.Core.Models.Match
{
    public class AllMatchesQueryModel
    {
        public const int MatchPerPage = 2;

        public string? SearchTerm { get; set; }

        public int CurrentPage { get; set; }

        public MatchSorting MatchSorting { get; set; }

        public int TotalMatchesCount { get; set; }

        public IList<MatchServiceModel> Matches { get; set; } = new List<MatchServiceModel>();
    }
}
