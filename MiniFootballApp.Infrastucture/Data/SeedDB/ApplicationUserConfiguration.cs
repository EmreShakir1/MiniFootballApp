using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniFootballApp.Infrastucture.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFootballApp.Infrastucture.Data.SeedDB
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new ApplicationUser[] { data.UserAdmin, data.UserGuest, data.UserPlayer3, data.UserPlayer4 });
        }
    }
}
