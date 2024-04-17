using MiniFootballApp.Core.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Match
{
    public class MatchFormModel
    {
        public DateTime StartingDate { get; set; }

        public string RefereeName { get; set; } = string.Empty;

        public int HomeTeamId { get; set; }


        public int AwayTeamId { get; set; }

        public IEnumerable<PlayerTeamServiceModel> Teams { get; set; } = new List<PlayerTeamServiceModel>();

        public int StadiumId { get; set; }

        public IEnumerable<MatchStadiumServiceModel> Stadiums { get; set; } = new List<MatchStadiumServiceModel>();
    }
}
