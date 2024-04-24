using System.ComponentModel.DataAnnotations;
using static MiniFootballApp.Core.Constants.MessageConstants;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Core.Models.Player
{
    public class BecomePlayerFormModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(PlayerKitNumberMinValue,PlayerKitNumberMaxValue
            ,ErrorMessage = RangeErrorMessage)]
        public int KitNumber { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(PlayerPositionMaxLength,
            ErrorMessage = LengthErrorMessage,
            MinimumLength = PlayerPositionMinLength)]
        public string Position { get; set; } = string.Empty;

        public int? TeamId { get; set; }

        public IEnumerable<PlayerTeamServiceModel> Teams {  get; set; } = new List<PlayerTeamServiceModel>();
    }
}
