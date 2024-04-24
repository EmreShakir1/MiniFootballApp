using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Team
{
    public class TeamDetailsServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string LogoUrl { get; set; } = string.Empty;

        public string CapitanName { get; set; } = string.Empty;

        public IEnumerable<TeamPlayerServiceModel> Players { get; set; } = new List<TeamPlayerServiceModel>();
    }
}
