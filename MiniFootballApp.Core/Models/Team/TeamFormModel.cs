using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Core.Models.Team
{
    public class TeamFormModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LogoUrl { get; set; } = string.Empty;

    }
}
