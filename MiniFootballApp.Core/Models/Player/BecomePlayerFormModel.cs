using MiniFootballApp.Infrastucture.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Player
{
    public class BecomePlayerFormModel
    {
        [Required]
        public int KitNumber { get; set; }

        [Required]
        public string Position { get; set; } = string.Empty;

        public int? TeamId { get; set; }

        public IEnumerable<PlayerTeamServiceModel> Teams {  get; set; } = new List<PlayerTeamServiceModel>();
    }
}
