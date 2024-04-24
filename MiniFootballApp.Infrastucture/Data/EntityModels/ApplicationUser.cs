using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static MiniFootballApp.Infrastucture.Constants.DataConstants;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    [Comment("The user of the application")]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        [Comment("First name of the application user")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        [Comment("Last name of the application user")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Age of the application user")]
        public int Age { get; set; }

    }
}
