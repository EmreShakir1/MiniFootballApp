using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Match
    {
        public int Id { get; set; }

        public DateTime StartingTime { get; set; }

        public string RefereeName { get; set; } = string.Empty;

        public Team HomeTeam { get; set; } = null!;

        public Team AwayTeam { get; set; } = null!;

        public Stadium Stadium { get; set; } = null!;
    }
}
