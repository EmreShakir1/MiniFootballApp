using MiniFootballApp.Infrastucture.Data.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public int KitNumber { get; set; }

        public Position Position { get; set; }

        public int? TeamId { get; set; }

        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; } = null!;

        public ApplicaitonUser ApplicaitonUser { get; set; } = null!;
    }
}
