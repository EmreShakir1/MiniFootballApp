using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Infrastucture.Data.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("Football player")]
    public class Player
    {
        [Key]
        [Comment("Identifier of player")]
        public int Id { get; set; }

        [Required]
        [Comment("Number back of the kit")]
        public int KitNumber { get; set; }

        [Required]
        [Comment("Played position")]
        public Position Position { get; set; }

        [Comment("Identifier for team")]
        public int? TeamId { get; set; }

        [ForeignKey(nameof(TeamId))]
        [Comment("Property for team")]
        public Team? Team { get; set; }

        [Comment("Identifier of app user")]
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        [Comment("Property of app user")]
        public ApplicationUser ApplicaitonUser { get; set; } = null!;
    }
}
