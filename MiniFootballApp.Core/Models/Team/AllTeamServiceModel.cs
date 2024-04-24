using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Team
{
    public class AllTeamServiceModel
    {
        public IEnumerable<TeamServiceModel> Teams { get; set; } = new List<TeamServiceModel>();
    }
}
