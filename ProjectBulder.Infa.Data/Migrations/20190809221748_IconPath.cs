using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class IconPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "611861bc-9af5-4e72-99b5-1db6e7e26d8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b23bb0f-50b8-457a-898d-216d22ef9bde");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7601a8e1-c065-4355-a1ba-12a203425a45", "0952c1a0-5ec0-4846-bcbb-2f684cc6168a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3bead6e4-b4a6-4ca5-8573-c68b9dd69bc6", "edb6f463-42c2-4208-9e0f-b2c463619ecc", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bead6e4-b4a6-4ca5-8573-c68b9dd69bc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7601a8e1-c065-4355-a1ba-12a203425a45");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "611861bc-9af5-4e72-99b5-1db6e7e26d8a", "760aaa68-114f-42a2-9e4c-88abdfa56751", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b23bb0f-50b8-457a-898d-216d22ef9bde", "d96eba28-00e1-4cf2-9c9f-6939f538719e", "Admin", "ADMIN" });
        }
    }
}
