using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

    }
}
