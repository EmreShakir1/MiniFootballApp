using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFootballApp.Infrastucture.Migrations
{
    public partial class UpdatedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_CapitanId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CapitanId",
                table: "Teams",
                newName: "CaptainId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CapitanId",
                table: "Teams",
                newName: "IX_Teams_CaptainId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3091a5c6-7004-42ae-86b3-191578b7e8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db25909c-13a4-4de0-8643-ad0013cd41e3", "AQAAAAEAACcQAAAAEN/ZZusbWHEQC9EgXqlPlNKVMQ+BvSrA/1uAslrHOKW2/AhoCU4aCOXgXxKCL3Lmhg==", "1fb00096-697f-4a60-88cf-8cc3534d40c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed99122-41b0-4c33-926f-a2c7fc6e6465",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80fab968-98e1-4f0c-82bc-ee6586d82323", "AQAAAAEAACcQAAAAEIOh9h2X2Y/QDAXY7F7iF7aDE6j5oRGcDCNKRp9T+VP8OqjGsFeZsprBGsG2epVe3Q==", "fa60bef6-83e7-4070-93c8-56a00544bc21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3e37fdb-818a-46ec-ad1e-4d6a3399a1a1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b26652b-225e-485d-8c0a-b878692d621f", "AQAAAAEAACcQAAAAEIvfJVXEvoHH4i1JLiQK/5VkgvB7pqlfjGkcvElybFeaURr392ZUYp2o8ZIeSh/pXg==", "105aae00-46ad-459f-ab67-381bb9ecaf93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba1d28a-2a5a-4ebf-86c9-eb93337731d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255f562a-0c53-4039-afe5-81eba74878c7", "AQAAAAEAACcQAAAAEHpuHxh/A08y1WIv5m2u9cAJCKG0SafmFaUc5pq7uaDH2FhrakvpiObD4Nzap4lztQ==", "caa12438-1b54-4348-b659-7bcba14feb07" });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_CaptainId",
                table: "Teams",
                column: "CaptainId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Players_CaptainId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CaptainId",
                table: "Teams",
                newName: "CapitanId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_CaptainId",
                table: "Teams",
                newName: "IX_Teams_CapitanId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Players_CapitanId",
                table: "Teams",
                column: "CapitanId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
