using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class InitiatorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5cb5ca-cdf1-4ecf-aca1-d8655253b76f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0fe6a4c-1110-4f3f-87b2-d688809b2474");

            migrationBuilder.AddColumn<string>(
                name: "InitatorName",
                table: "Projects",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ee88693-878c-45e1-9c34-e82e2bbc6ea7", "e0173408-189e-43d5-a86c-8eb4d9ff49ee", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1c2c85a-b1e7-4a57-9bac-b73bb21e9ced", "19fcaa7f-4ace-43c1-b2d2-2be2fd767972", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ee88693-878c-45e1-9c34-e82e2bbc6ea7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1c2c85a-b1e7-4a57-9bac-b73bb21e9ced");

            migrationBuilder.DropColumn(
                name: "InitatorName",
                table: "Projects");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0fe6a4c-1110-4f3f-87b2-d688809b2474", "8a042c9c-162c-473b-8887-35f535f8dee8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d5cb5ca-cdf1-4ecf-aca1-d8655253b76f", "f40dfc02-0e49-4afa-8a3d-5b6fb1afd785", "Admin", "ADMIN" });
        }
    }
}
