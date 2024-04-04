using Microsoft.AspNetCore.Identity;
using MiniFootballApp.Infrastucture.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.EntityModels
{
    public class Player
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public int Age { get; set; }

        public int KitNumber { get; set; }

        public Position Position { get; set; }

        public Team Team { get; set; } = null!;

        public IdentityUser IdentityUser { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
    }
}
