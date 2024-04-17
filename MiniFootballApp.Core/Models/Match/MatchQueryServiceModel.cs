using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Match
{
    public class MatchQueryServiceModel
    {
        public int TotalMatchesCount { get; set; }

        public List<MatchServiceModel> matches { get; set; } = new List<MatchServiceModel>();
    }
}
