using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Match
{
    public class MatchServiceModel
    {
        public int Id { get; set; }

        public string RefereeName { get; set; } = string.Empty;

        public string StartingTime { get; set; } = string.Empty;

        public bool IsPlayed { get; set; }

        public string? Result { get; set; } = string.Empty;

        public string HomeTeamName { get; set; } = string.Empty;

        public string AwayTeamName { get; set; } = string.Empty;

        public string StadiumName { get; set; } = string.Empty;
    }
}
