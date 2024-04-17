using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("Football match in the app")]
    public class Match
    {
        [Key]
        [Comment("Identifier of match")]
        public int Id { get; set; }

        [Comment("Date of the match")]
        [Required]
        public DateTime StartingTime { get; set; }

        [MaxLength(MatchRefereeNameMaxLength)]
        [Comment("Name of referee")]
        [Required]
        public string RefereeName { get; set; } = string.Empty;

        [Comment("Does the match is played")]
        [Required]
        public bool IsPlayed { get; set; }

        [MaxLength(MatchResultMaxLength)]
        [Comment("Result of the match")]
        public string? Result { get; set; }

        [Required]
        [Comment("Identifier of home team")]
        public int HomeTeamId { get; set; }

        [ForeignKey(nameof(HomeTeamId))]
        [InverseProperty("HomeMatches")]
        [Comment("Property of home team")]
        public Team HomeTeam { get; set; } = null!;

        [Required]
        [Comment("Identifier of away team")]
        public int AwayTeamId { get; set; }

        [ForeignKey(nameof(AwayTeamId))]
        [InverseProperty("AwayMatches")]
        [Comment("Property of away team")]
        public Team AwayTeam { get; set; } = null!;

        [Required]
        [Comment("Identifier of stadium")]
        public int StadiumId { get; set; }

        [ForeignKey(nameof(StadiumId))]
        [Comment("Property of stadium")]
        public Stadium Stadium { get; set; } = null!;
    }
}
