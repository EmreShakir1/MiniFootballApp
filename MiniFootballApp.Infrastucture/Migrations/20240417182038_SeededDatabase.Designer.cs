﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniFootballApp.Infrastucture.Data;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    [DbContext(typeof(MiniFootballDbContext))]
    [Migration("20240417182038_SeededDatabase")]
    partial class SeededDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasComment("Age of the application user");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasComment("First name of the application user");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("Last name of the application user");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("The user of the application");

                    b.HasData(
                        new
                        {
                            Id = "3091a5c6-7004-42ae-86b3-191578b7e8a6",
                            AccessFailedCount = 0,
                            Age = 25,
                            ConcurrencyStamp = "249da6d9-1bd3-4b87-a99f-0cac2542b865",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFzdxFGo9tM8+5ArEynvIuFLVYY7CJauQ5cZYb3qHj+ZJLK+iv0XNhazdKI2DuaJKg==",
                            PhoneNumber = "+359888654321",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6d01030d-a563-4e79-9639-edfe5ea2874d",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "fba1d28a-2a5a-4ebf-86c9-eb93337731d0",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "11377a7a-a37a-4f4f-94f6-3eb5ca4cb8a0",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "Guestov",
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGGZWzNkD5U4tiR50/Tpz6beM2/KrcQJzB0+8SEitUW4aIq5rUkg07HaU2SgLFXAbw==",
                            PhoneNumber = "+359888123456",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56465c96-73c7-441a-b128-a03d8f7a2d1f",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "5ed99122-41b0-4c33-926f-a2c7fc6e6465",
                            AccessFailedCount = 0,
                            Age = 25,
                            ConcurrencyStamp = "365ab29a-b328-443b-9799-385b44ac732c",
                            Email = "player3@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Player3",
                            LastName = "Playerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PLAYER3@MAIL.COM",
                            NormalizedUserName = "PLAYER3@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHJXsdOX+4ZkfWrtusFFwya918WlROsRwdExe5mNQcy6ekPC/dzdDyHzEbDdvpf7Uw==",
                            PhoneNumber = "+359888654322",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6987de3c-1dce-4f7b-8e7c-df9767821b79",
                            TwoFactorEnabled = false,
                            UserName = "player3@mail.com"
                        },
                        new
                        {
                            Id = "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1",
                            AccessFailedCount = 0,
                            Age = 25,
                            ConcurrencyStamp = "07cb06bd-b117-4e22-9fc3-f58ae74f8250",
                            Email = "player4@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Player4",
                            LastName = "Playerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "PLAYER4@MAIL.COM",
                            NormalizedUserName = "PLAYER4@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBQmar5W6kPI4vwNPwlWUnJkQ4KYDoTzI1c3cHe2PdJrFeuXLkLrLjl8EWnVuuqHuQ==",
                            PhoneNumber = "+359888654323",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d637dce-9c28-4e56-a3ab-5e0269530fc3",
                            TwoFactorEnabled = false,
                            UserName = "player4@mail.com"
                        });
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identifier of location");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Address of the location");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Country of the location");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasComment("Location of stadium in the app");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Bulgaria str N:1",
                            Country = "Bulgaria"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Hristo Botev str N:12",
                            Country = "Bulgaria"
                        });
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identifier of match");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int")
                        .HasComment("Identifier of away team");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int")
                        .HasComment("Identifier of home team");

                    b.Property<bool>("IsPlayed")
                        .HasColumnType("bit")
                        .HasComment("Does the match is played");

                    b.Property<string>("RefereeName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasComment("Name of referee");

                    b.Property<string>("Result")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasComment("Result of the match");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int")
                        .HasComment("Identifier of stadium");

                    b.Property<DateTime>("StartingTime")
                        .HasColumnType("datetime2")
                        .HasComment("Date of the match");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");

                    b.HasComment("Football match in the app");
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identifier of player");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KitNumber")
                        .HasColumnType("int")
                        .HasComment("Number back of the kit");

                    b.Property<int>("Position")
                        .HasColumnType("int")
                        .HasComment("Played position");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int")
                        .HasComment("Identifier for team");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Identifier of app user");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");

                    b.HasComment("Football player");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KitNumber = 1,
                            Position = 3,
                            UserId = "3091a5c6-7004-42ae-86b3-191578b7e8a6"
                        },
                        new
                        {
                            Id = 2,
                            KitNumber = 2,
                            Position = 1,
                            UserId = "fba1d28a-2a5a-4ebf-86c9-eb93337731d0"
                        },
                        new
                        {
                            Id = 3,
                            KitNumber = 11,
                            Position = 2,
                            UserId = "5ed99122-41b0-4c33-926f-a2c7fc6e6465"
                        },
                        new
                        {
                            Id = 4,
                            KitNumber = 12,
                            Position = 0,
                            UserId = "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1"
                        });
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identifier of the stadium");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasComment("Spactators capacity of stadium");

                    b.Property<int>("LocationId")
                        .HasColumnType("int")
                        .HasComment("Identifier for location");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the stadium");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Stadiums");

                    b.HasComment("Football stadium");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 100,
                            LocationId = 1,
                            Name = "Marakana"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 200,
                            LocationId = 2,
                            Name = "Shipka"
                        });
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Identifier of team");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CaptainId")
                        .HasColumnType("int")
                        .HasComment("Identifier of team captain");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit")
                        .HasComment("Approval of admin");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Link/Path to the logo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the team");

                    b.HasKey("Id");

                    b.HasIndex("CaptainId");

                    b.ToTable("Teams");

                    b.HasComment("Football team");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Match", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Team", "AwayTeam")
                        .WithMany("AwayMatches")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Team", "HomeTeam")
                        .WithMany("HomeMatches")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Stadium", "Stadium")
                        .WithMany()
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Player", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.ApplicationUser", "ApplicaitonUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicaitonUser");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Stadium", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Team", b =>
                {
                    b.HasOne("MiniFootballApp.Infrastucture.Data.EntityModels.Player", "Captain")
                        .WithMany()
                        .HasForeignKey("CaptainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Captain");
                });

            modelBuilder.Entity("MiniFootballApp.Infrastucture.Data.EntityModels.Team", b =>
                {
                    b.Navigation("AwayMatches");

                    b.Navigation("HomeMatches");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
