using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("Football stadium")]
    public class Stadium
    {
        [Key]
        [Comment("Identifier of the stadium")]
        public int Id { get; set; }

        [MaxLength(StadiumNameMaxLength)]
        [Comment("Name of the stadium")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Spactators capacity of stadium")]
        public int Capacity { get; set; }

        [Comment("Photo of the stadium")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Identifier for location")]
        public int LocationId { get; set; }

        [ForeignKey(nameof(LocationId))]
        [Comment("Property for location")]
        public Location Location { get; set; } = null!;
    }
}
