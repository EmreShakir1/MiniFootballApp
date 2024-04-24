using MiniFootballApp.Core.Models.Player;
using System.ComponentModel.DataAnnotations;
using static MiniFootballApp.Core.Constants.MessageConstants;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Core.Models.Match
{
    public class MatchFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Match start day")]
        public DateTime StartingDate { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(MatchRefereeNameMaxLength,
            ErrorMessage = LengthErrorMessage,
            MinimumLength = MatchRefereeNameMinLength)]
        [Display(Name = "Referee name")]
        public string RefereeName { get; set; } = string.Empty;

        [Display(Name = "Home team")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int HomeTeamId { get; set; }

        [Display(Name = "Away team")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int AwayTeamId { get; set; }

        [Display(Name = "Stadium")]
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int StadiumId { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; } = string.Empty;

        [Display(Name = "Played or not")]
        public string IsPlayed { get; set; }

        public IEnumerable<PlayerTeamServiceModel> Teams { get; set; } = new List<PlayerTeamServiceModel>();


        public IEnumerable<MatchStadiumServiceModel> Stadiums { get; set; } = new List<MatchStadiumServiceModel>();
    }
}
