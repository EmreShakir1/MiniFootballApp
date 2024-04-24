using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    public partial class AddedImageColumnForStadium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Photo of the stadium");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Stadiums");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3091a5c6-7004-42ae-86b3-191578b7e8a6", 0, 25, "249da6d9-1bd3-4b87-a99f-0cac2542b865", "admin@mail.com", false, "Admin", "Adminov", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEFzdxFGo9tM8+5ArEynvIuFLVYY7CJauQ5cZYb3qHj+ZJLK+iv0XNhazdKI2DuaJKg==", "+359888654321", false, "6d01030d-a563-4e79-9639-edfe5ea2874d", false, "admin@mail.com" },
                    { "5ed99122-41b0-4c33-926f-a2c7fc6e6465", 0, 25, "365ab29a-b328-443b-9799-385b44ac732c", "player3@mail.com", false, "Player3", "Playerov", false, null, "PLAYER3@MAIL.COM", "PLAYER3@MAIL.COM", "AQAAAAEAACcQAAAAEHJXsdOX+4ZkfWrtusFFwya918WlROsRwdExe5mNQcy6ekPC/dzdDyHzEbDdvpf7Uw==", "+359888654322", false, "6987de3c-1dce-4f7b-8e7c-df9767821b79", false, "player3@mail.com" },
                    { "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1", 0, 25, "07cb06bd-b117-4e22-9fc3-f58ae74f8250", "player4@mail.com", false, "Player4", "Playerov", false, null, "PLAYER4@MAIL.COM", "PLAYER4@MAIL.COM", "AQAAAAEAACcQAAAAEBQmar5W6kPI4vwNPwlWUnJkQ4KYDoTzI1c3cHe2PdJrFeuXLkLrLjl8EWnVuuqHuQ==", "+359888654323", false, "9d637dce-9c28-4e56-a3ab-5e0269530fc3", false, "player4@mail.com" },
                    { "fba1d28a-2a5a-4ebf-86c9-eb93337731d0", 0, 20, "11377a7a-a37a-4f4f-94f6-3eb5ca4cb8a0", "guest@mail.com", false, "Guest", "Guestov", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEGGZWzNkD5U4tiR50/Tpz6beM2/KrcQJzB0+8SEitUW4aIq5rUkg07HaU2SgLFXAbw==", "+359888123456", false, "56465c96-73c7-441a-b128-a03d8f7a2d1f", false, "guest@mail.com" }
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
                columns: new[] { "Id", "Capacity", "LocationId", "Name" },
                values: new object[,]
                {
                    { 1, 100, 1, "Marakana" },
                    { 2, 200, 2, "Shipka" }
                });
        }
    }
}
