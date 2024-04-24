using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3091a5c6-7004-42ae-86b3-191578b7e8a6", 0, 25, "90d43b75-2b8a-471e-8fab-bd7c9de3a906", "admin@mail.com", false, "Admin", "Adminov", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFBHsZtudGkp8ArMDnPcMQYrzkn4L+zRr2NapY51+cU4pH1Et9GYX/nVCjUjSZYTPw==", "+359888654321", false, "9f4d3329-5430-43a2-b4f9-b01273a9d641", false, "admin@mail.com" },
                    { "5ed99122-41b0-4c33-926f-a2c7fc6e6465", 0, 25, "05a844b1-f412-407c-8d18-00cb89e2ce68", "player3@mail.com", false, "Player3", "Playerov", false, null, "PLAYER3@MAIL.COM", "PLAYER3@MAIL.COM", "AQAAAAEAACcQAAAAECT5kZdRZhp7oI7vlLI4iVXUIfxanDTCyKmNbOYm70L7pTyAC/3PWhNqL8u0Ykv39Q==", "+359888654322", false, "72a1d65d-1717-4f0b-9b4f-04246001f731", false, "player3@mail.com" },
                    { "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1", 0, 25, "cfbbbcaa-abc9-4d46-9fd3-4a31237629d9", "player4@mail.com", false, "Player4", "Playerov", false, null, "PLAYER4@MAIL.COM", "PLAYER4@MAIL.COM", "AQAAAAEAACcQAAAAEB6SPA+b/CPf0743fd2zEEFCwpnX5KFJqOq1rV14T+noKue8TjHeOcTKBwrBRlbvYQ==", "+359888654323", false, "dc7ad1b0-f38c-42fb-8c91-60e5316574b9", false, "player4@mail.com" },
                    { "fba1d28a-2a5a-4ebf-86c9-eb93337731d0", 0, 20, "fce3243c-979f-4eb0-b547-c09129457e4e", "guest@mail.com", false, "Guest", "Guestov", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAENatAEhPpQTW/BbIdLLtICrIymv6V++IrjTv8nNjjz1V/ZPYeGKs8T7uNDHWwXvj6A==", "+359888123456", false, "ec77005b-72fe-4b46-bec2-68194c5fd751", false, "guest@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Country" },
                values: new object[,]
                {
                    { 1, "Bulgaria str N:1", "Bulgaria" },
                    { 2, "Hristo Botev str N:12", "Bulgaria" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "KitNumber", "Position", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 3, null, "3091a5c6-7004-42ae-86b3-191578b7e8a6" },
                    { 2, 2, 1, null, "fba1d28a-2a5a-4ebf-86c9-eb93337731d0" },
                    { 3, 11, 2, null, "5ed99122-41b0-4c33-926f-a2c7fc6e6465" },
                    { 4, 12, 0, null, "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1" }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Capacity", "ImageUrl", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, 100, "~/Images/Stadiums/Marakana.jpg", 1, "Marakana" },
                    { 2, 200, "~/Images/Stadiums/Shipka.webp", 2, "Shipka" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3091a5c6-7004-42ae-86b3-191578b7e8a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed99122-41b0-4c33-926f-a2c7fc6e6465");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba1d28a-2a5a-4ebf-86c9-eb93337731d0");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
