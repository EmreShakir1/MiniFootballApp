using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LogoUrl { get; set; } = string.Empty;

        public bool IsApproved { get; set; }

        [Required]
        public int CaptainId { get; set; }

        [ForeignKey(nameof(CaptainId))]
        public Player Captain { get; set; } = null!;

        public IList<Match> HomeMatches { get; set; } = new List<Match>();

        public IList<Match> AwayMatches { get; set; } = new List<Match>();

        public IList<Player> Players { get; set; } = new List<Player>();
    }
}
