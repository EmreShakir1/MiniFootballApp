using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Core.Contracts;
using MiniFootballApp.Core.Services;
using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.Common;
using MiniFootballApp.Infrastucture.Data.EntityModels;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ITeamService, TeamService>();

            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<MiniFootballDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IRepository,Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MiniFootballDbContext>();

            return services;
        }
    }
}
