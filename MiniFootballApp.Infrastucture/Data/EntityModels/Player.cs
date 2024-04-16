using MiniFootballApp.Infrastucture.Data.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int KitNumber { get; set; }

        [Required]
        public Position Position { get; set; }

        public int? TeamId { get; set; }

        [ForeignKey(nameof(TeamId))]
        public Team? Team { get; set; }

        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicaitonUser { get; set; } = null!;
    }
}
