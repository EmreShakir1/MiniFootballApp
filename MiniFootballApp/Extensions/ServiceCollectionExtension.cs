﻿using Microsoft.EntityFrameworkCore;
using MiniFootballApp.Infrastucture.Data;
using MiniFootballApp.Infrastucture.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
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
            services.AddDefaultIdentity<ApplicationIdentity>(options =>
            {
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            })
                .AddEntityFrameworkStores<MiniFootballDbContext>();

            return services;
        }
    }
}
