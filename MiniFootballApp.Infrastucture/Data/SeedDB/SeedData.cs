using Microsoft.AspNetCore.Identity;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using MiniFootballApp.Infrastucture.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MiniFootballApp.Infrastucture.Data.SeedDB
{
    public class SeedData
    {
        public SeedData()
        {
            SeedLocation();

            SeedStadiums();

            SeedApplicationUsers();


            SeedPlayers();

            SeedTeams();

            SeedMatches();

        }

        public Player Player1 { get; set; } = null!;

        public Player Player2 { get; set; } = null!;

        public Player Player3 { get; set; } = null!;

        public Player Player4 { get; set; } = null!;

        public Stadium Stadium1 { get; set; } = null!;

        public Stadium Stadium2 { get; set; } = null!;

        public Team Team1 { get; set; } = null!;

        public Team Team2 { get; set; } = null!;

        public Match Match1 { get; set; } = null!;

        public Match Match2 { get; set; } = null!;

        public Location Location1 { get; set; } = null!;

        public Location Location2 { get; set; } = null!;

        public ApplicationUser UserGuest { get; set; } = null!;

        public ApplicationUser UserAdmin { get; set; } = null!;
        public ApplicationUser UserPlayer3 { get; set; } = null!;
        public ApplicationUser UserPlayer4 { get; set; } = null!;

        private void SeedLocation()
        {
            Location1 = new Location()
            {
                Id = 1,
                Address = "Bulgaria str N:1",
                Country = "Bulgaria",
            };

            Location2 = new Location()
            {
                Id = 2,
                Address = "Hristo Botev str N:12",
                Country = "Bulgaria",
            };
        }

        private void SeedStadiums()
        {
            Stadium1 = new Stadium()
            {
                Id = 1,
                Capacity = 100,
                Name = "Marakana",
                LocationId = 1,

            };

            Stadium2 = new Stadium()
            {
                Id = 2,
                Capacity = 200,
                Name = "Shipka",
                LocationId = 2,

            };
        }

        private void SeedApplicationUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            UserGuest = new ApplicationUser()
            {
                Id = "fba1d28a-2a5a-4ebf-86c9-eb93337731d0",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                FirstName = "Guest",
                LastName = "Guestov",
                Age = 20,
                PhoneNumber = "+359888123456",
            };

            UserGuest.PasswordHash = hasher.HashPassword(UserGuest, "guest123");

            UserAdmin = new ApplicationUser()
            {
                Id = "3091a5c6-7004-42ae-86b3-191578b7e8a6",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Admin",
                LastName = "Adminov",
                Age = 25,
                PhoneNumber = "+359888654321",
            };

            UserAdmin.PasswordHash = hasher.HashPassword(UserAdmin, "admin123");

            UserPlayer3 = new ApplicationUser()
            {
                Id = "5ed99122-41b0-4c33-926f-a2c7fc6e6465",
                UserName = "player3@mail.com",
                NormalizedUserName = "PLAYER3@MAIL.COM",
                Email = "player3@mail.com",
                NormalizedEmail = "PLAYER3@MAIL.COM",
                FirstName = "Player3",
                LastName = "Playerov",
                Age = 25,
                PhoneNumber = "+359888654322",
            };

            UserPlayer3.PasswordHash = hasher.HashPassword(UserPlayer3, "player3123"); 

            UserPlayer4 = new ApplicationUser()
            {
                Id = "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1",
                UserName = "player4@mail.com",
                NormalizedUserName = "PLAYER4@MAIL.COM",
                Email = "player4@mail.com",
                NormalizedEmail = "PLAYER4@MAIL.COM",
                FirstName = "Player4",
                LastName = "Playerov",
                Age = 25,
                PhoneNumber = "+359888654323",
            };

            UserPlayer4.PasswordHash = hasher.HashPassword(UserPlayer4, "player4123");
        }

        private void SeedPlayers()
        {
            Player1 = new Player()
            {
                Id = 1,
                KitNumber = 1,
                Position = Position.Forward,
                UserId = UserAdmin.Id,
            };

            Player2 = new Player()
            {
                Id = 2,
                UserId = UserGuest.Id,
                KitNumber = 2,
                Position = Position.Defender,
            };

            Player3 = new Player()
            {
                Id = 3,
                UserId = UserPlayer3.Id,
                KitNumber = 11,
                Position = Position.Midfielder,
            };

            Player4 = new Player()
            {
                Id = 4,
                UserId = UserPlayer4.Id,
                KitNumber = 12,
                Position = Position.Goalkeeper,
            };
        }

        private void SeedTeams()
        {
            Team1 = new Team()
            {
                Id = 1,
                Name = "Manchester UTD",
                LogoUrl = "https://marketplace.canva.com/EAFIdGdKVWc/1/0/1600w/canva-red-minimalist-skull-warrior-illustration-gaming-logo-w5IuEYm6TJM.jpg",
                CapitanId = Player1.Id,
                IsApproved = true,
                
            };

            Team1 = new Team()
            {
                Id = 2,
                Name = "Chelsi",
                LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1fL_BDbcPCdYuxn8tyAYHjW0-UGGBbbxWdbF4b5Y12Q&s",
                CapitanId = Player2.Id,
                IsApproved = true,
            };
        }

        private void SeedMatches()
        {
            Match1 = new Match()
            {
                Id = 1,
                HomeTeam = Team1,
                AwayTeam = Team2,
                HomeTeamId = 1,
                AwayTeamId = 2,
                IsPlayed = false,
                RefereeName = "RefereeA",
                Stadium = Stadium1,
                StadiumId = 1,
                Result = "",
                StartingTime = DateTime.Now,
            };

            Match2 = new Match()
            {
                Id = 2,
                HomeTeam = Team2,
                AwayTeam = Team1,
                HomeTeamId = 2,
                AwayTeamId = 1,
                IsPlayed = true,
                RefereeName = "RefereeB",
                Stadium = Stadium2,
                StadiumId = 2,
                Result = "0-3",
                StartingTime = DateTime.Parse("1/1/2024"),
            };
        }
    }
}
