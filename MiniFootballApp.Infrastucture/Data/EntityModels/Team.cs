using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string LogoUrl { get; set; } = string.Empty;

        public Player Captain { get; set; } = null!;

        public IList<Match> PlayedMatches { get; set; } = new List<Match>();

        public IList<Player> Players { get; set; } = new List<Player>();
    }
}
