using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class ChangeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ee88693-878c-45e1-9c34-e82e2bbc6ea7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1c2c85a-b1e7-4a57-9bac-b73bb21e9ced");

            migrationBuilder.RenameColumn(
                name: "InitatorName",
                table: "Projects",
                newName: "InitiatorName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b67fb53-1501-4ebb-8358-718b7b6c6fff", "7f7392ae-af35-456b-aa7c-91016fa1ccb6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54c3672d-208d-4fd7-a7ad-22a85c89edd9", "5d378042-0151-4932-84b7-079265d96ebf", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54c3672d-208d-4fd7-a7ad-22a85c89edd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b67fb53-1501-4ebb-8358-718b7b6c6fff");

            migrationBuilder.RenameColumn(
                name: "InitiatorName",
                table: "Projects",
                newName: "InitatorName");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ee88693-878c-45e1-9c34-e82e2bbc6ea7", "e0173408-189e-43d5-a86c-8eb4d9ff49ee", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1c2c85a-b1e7-4a57-9bac-b73bb21e9ced", "19fcaa7f-4ace-43c1-b2d2-2be2fd767972", "Admin", "ADMIN" });
        }
    }
}
