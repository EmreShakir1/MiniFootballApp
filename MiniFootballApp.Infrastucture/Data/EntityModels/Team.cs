using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("Football team")]
    public class Team
    {
        [Key]
        [Comment("Identifier of team")]
        public int Id { get; set; }

        [MaxLength(TeamNameMaxLength)]
        [Required]
        [Comment("Name of the team")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Link/Path to the logo")]
        public string LogoUrl { get; set; } = string.Empty;

        [Comment("Approval of admin")]
        public bool IsApproved { get; set; }

        [Required]
        [Comment("Identifier of team captain")]
        public int CaptainId { get; set; }

        [ForeignKey(nameof(CaptainId))]
        [Comment("Property for team captain")]
        public Player Captain { get; set; } = null!;

        [Comment("Collection of all home matches")]
        public IList<Match> HomeMatches { get; set; } = new List<Match>();

        [Comment("Collection of all away matches")]
        public IList<Match> AwayMatches { get; set; } = new List<Match>();

        [Comment("Collation of all player")]
        public IList<Player> Players { get; set; } = new List<Player>();
    }
}
