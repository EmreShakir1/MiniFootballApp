using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartingTime { get; set; }

        [MaxLength(50)]
        public string RefereeName { get; set; } = string.Empty;

        public bool IsPlayed { get; set; }

        [MaxLength(10)]
        public string? Result { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        [ForeignKey(nameof(HomeTeamId))]
        [InverseProperty("HomeMatches")]
        public Team HomeTeam { get; set; } = null!;

        [Required]
        public int AwayTeamId { get; set; }

        [ForeignKey(nameof(AwayTeamId))]
        [InverseProperty("AwayMatches")]
        public Team AwayTeam { get; set; } = null!;

        [Required]  
        public int StadiumId { get; set; }

        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;
    }
}
