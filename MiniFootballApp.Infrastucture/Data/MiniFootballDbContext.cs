using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using MiniFootballApp.Infrastucture.Data.SeedDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data
{
    public class MiniFootballDbContext : IdentityDbContext<ApplicationUser>
    {
        private bool seedDb;

        public MiniFootballDbContext(DbContextOptions<MiniFootballDbContext> options, bool _seedDb = true) : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            seedDb = _seedDb;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Match>()
                .HasOne(m => m.HomeTeam)
                .WithMany(ht => ht.HomeMatches)
                .HasForeignKey(m => m.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Match>()
                .HasOne(m => m.AwayTeam)
                .WithMany(at => at.AwayMatches)
                .HasForeignKey(m => m.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Player>()
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(p => p.TeamId)
                .OnDelete(DeleteBehavior.Restrict);

            if (seedDb)
            {
                builder.ApplyConfiguration(new LocationConfiguration());
                builder.ApplyConfiguration(new StadiumConfiguration());
                builder.ApplyConfiguration(new ApplicationUserConfiguration());
                builder.ApplyConfiguration(new PlayerConfiguration());
                //builder.ApplyConfiguration(new TeamConfiguration());
                //builder.ApplyConfiguration(new MatchConfiguration());
            }

            base.OnModelCreating(builder);
        }

        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Stadium> Stadiums { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
    }
}
