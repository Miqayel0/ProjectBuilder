using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class Projec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bd3719d-bbe4-4eee-a665-2ee30ae774b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfbc33ec-574e-47b8-9273-f1bc800eb668");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed2fb3da-75a4-4903-8242-fee98a285376", "10660fe4-d9ea-4942-9cec-0171e6bfcadc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edeba54b-454e-44c8-b333-6c4519f37a24", "ed8ee48a-734c-4c0f-be90-4a51f0503143", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2fb3da-75a4-4903-8242-fee98a285376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edeba54b-454e-44c8-b333-6c4519f37a24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfbc33ec-574e-47b8-9273-f1bc800eb668", "a7963c2d-83ac-4906-95d0-327c1613ca38", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3bd3719d-bbe4-4eee-a665-2ee30ae774b6", "1df23776-c36c-4746-8c6f-03b9e8646a82", "Admin", "ADMIN" });
        }
    }
}
