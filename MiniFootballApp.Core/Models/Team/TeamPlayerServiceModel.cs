using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Team
{
    public class TeamPlayerServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int KitNumber { get; set; }

        public string Position { get; set; } = string.Empty;
    }
}
