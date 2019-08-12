using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class Donation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38173251-3785-4575-b9fb-a196fbe582fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e388487c-e5bd-4106-9025-e042d06b6e98");

            migrationBuilder.AlterColumn<int>(
                name: "DonationsCount",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b1e276e-5fd5-4f34-bfa1-a3ca017c2e14", "e9e97353-cafa-4dbe-8b59-cf0e652fa806", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf7bfd51-ecc1-4c1f-b1cc-d8fa91bd1c24", "36c8a7f2-63b6-4e84-bdbd-86807418e0f4", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b1e276e-5fd5-4f34-bfa1-a3ca017c2e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf7bfd51-ecc1-4c1f-b1cc-d8fa91bd1c24");

            migrationBuilder.AlterColumn<int>(
                name: "DonationsCount",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e388487c-e5bd-4106-9025-e042d06b6e98", "edfea3a4-c948-4f9f-9b02-504e6cf55a02", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38173251-3785-4575-b9fb-a196fbe582fe", "bfe6aa05-d9f0-4134-87a0-eb95669d7a03", "Admin", "ADMIN" });
        }
    }
}
