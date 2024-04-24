using System.ComponentModel.DataAnnotations;
using static MiniFootballApp.Core.Constants.MessageConstants;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Core.Models.Team
{
    public class TeamFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(TeamNameMaxLength,
            ErrorMessage = LengthErrorMessage,
            MinimumLength = TeamNameMinLength)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string LogoUrl { get; set; } = string.Empty;

    }
}
