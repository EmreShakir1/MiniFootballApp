using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    public partial class AddedDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stadiums",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Matches",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefereeName",
                table: "Matches",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Locations",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3091a5c6-7004-42ae-86b3-191578b7e8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbcd6c6b-ca87-479b-bc6a-eb98430741a6", "AQAAAAEAACcQAAAAEHuZ1hhU9q+Iv39nMuz03IbRqQ6uFxHawpf2IRr3/A+nThTzP1DhKdjpj/wXE6oLGA==", "29073bc9-aeda-49cf-9fc0-4271d7412929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed99122-41b0-4c33-926f-a2c7fc6e6465",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e860c1-5479-41b5-bc4b-83a80ce98601", "AQAAAAEAACcQAAAAEIzOycSobwfqDog41DItibMCHPDXb3Igyef4r0eYc6B9QTLBsW/wYc91Y9K2fH6qVg==", "b90f001d-e58d-45e0-9045-f5cf09e152a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f092297a-9413-44aa-bcd8-325bb028ca52", "AQAAAAEAACcQAAAAEJSFmB2qz5ofMDX0n1GnEJpOoaAUnoopbpUvA4Xq+cEr4i6POaVZzgvWEOvwQksPVQ==", "7ec7d4c7-521f-4b6d-bc76-76ff7578db24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba1d28a-2a5a-4ebf-86c9-eb93337731d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "907eea70-846a-45cb-8d6e-c59843f61daf", "AQAAAAEAACcQAAAAEIkbAoweTRTMNXCFzt6T3bzoFvSjvdCtI84u+wOVqjWMEHLRimHezqHxRrPJBnlwUg==", "eb9ebaa2-c3cd-4b29-bb4a-cfd31c31d9ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefereeName",
                table: "Matches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3091a5c6-7004-42ae-86b3-191578b7e8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f143022-2975-489f-b9c7-354814795901", "AQAAAAEAACcQAAAAEF5C9/ZmyfYe6TvS39ttXNuWxtycLzrKYKceD1J375buc9qP14Z68eLN1DECfxeufw==", "082517e9-5354-4394-8225-2b444b742879" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed99122-41b0-4c33-926f-a2c7fc6e6465",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0978effb-e115-42be-9fe9-e8c4e4f5f74d", "AQAAAAEAACcQAAAAEGkOrK9TfbQE65497SU7+Ed2bwoMJCYvZ6vv0phC6y16JV+gio2bs1bP95YeEdlvMQ==", "b635ec27-738b-456b-bae3-796b64ccf387" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7db3245c-33a8-466a-9bac-db6cd5c29418", "AQAAAAEAACcQAAAAEBAGxzWbV8y/D7b3MqveBVUidT9+0yz4MBC/nOWYeI1pGuuhXX/S/Ot7NfQhRVSZrw==", "e69e2c11-20bd-4d79-b348-8b81898a101e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba1d28a-2a5a-4ebf-86c9-eb93337731d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d401d680-026e-4b38-bb68-664cfeb721a2", "AQAAAAEAACcQAAAAEO6csXlIgjCFUvrOPRdjs2BYzDIJH90X//C/9AbUkXTdAWUFDXzpIxIkFO47yhKTdA==", "3a211bc6-1cc0-416c-81f2-e089911239b5" });
        }
    }
}
