using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("Location of stadium in the app")]
    public class Location
    {
        [Key]
        [Comment("Identifier of location")]
        public int Id { get; set; }

        [Required]
        [MaxLength(LocationAddressMaxLength)]
        [Comment("Address of the location")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(LocationCountryMaxLength)]
        [Comment("Country of the location")]
        public string Country { get; set; } = string.Empty;
    }
}
