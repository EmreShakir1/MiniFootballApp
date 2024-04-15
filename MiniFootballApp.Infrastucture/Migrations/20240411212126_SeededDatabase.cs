using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    public partial class SeededDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3091a5c6-7004-42ae-86b3-191578b7e8a6", 0, 25, "4f143022-2975-489f-b9c7-354814795901", "admin@mail.com", false, "Admin", "Adminov", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEF5C9/ZmyfYe6TvS39ttXNuWxtycLzrKYKceD1J375buc9qP14Z68eLN1DECfxeufw==", "+359888654321", false, "082517e9-5354-4394-8225-2b444b742879", false, "admin@mail.com" },
                    { "5ed99122-41b0-4c33-926f-a2c7fc6e6465", 0, 25, "0978effb-e115-42be-9fe9-e8c4e4f5f74d", "player3@mail.com", false, "Player3", "Playerov", false, null, "PLAYER3@MAIL.COM", "PLAYER3@MAIL.COM", "AQAAAAEAACcQAAAAEGkOrK9TfbQE65497SU7+Ed2bwoMJCYvZ6vv0phC6y16JV+gio2bs1bP95YeEdlvMQ==", "+359888654322", false, "b635ec27-738b-456b-bae3-796b64ccf387", false, "player3@mail.com" },
                    { "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1", 0, 25, "7db3245c-33a8-466a-9bac-db6cd5c29418", "player4@mail.com", false, "Player4", "Playerov", false, null, "PLAYER4@MAIL.COM", "PLAYER4@MAIL.COM", "AQAAAAEAACcQAAAAEBAGxzWbV8y/D7b3MqveBVUidT9+0yz4MBC/nOWYeI1pGuuhXX/S/Ot7NfQhRVSZrw==", "+359888654323", false, "e69e2c11-20bd-4d79-b348-8b81898a101e", false, "player4@mail.com" },
                    { "fba1d28a-2a5a-4ebf-86c9-eb93337731d0", 0, 20, "d401d680-026e-4b38-bb68-664cfeb721a2", "guest@mail.com", false, "Guest", "Guestov", false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEO6csXlIgjCFUvrOPRdjs2BYzDIJH90X//C/9AbUkXTdAWUFDXzpIxIkFO47yhKTdA==", "+359888123456", false, "3a211bc6-1cc0-416c-81f2-e089911239b5", false, "guest@mail.com" }
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
