using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class Finished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67663154-b757-48dc-b8ea-68adf73a9a37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a287f90e-5332-43fc-9b96-9f52173e06ec");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Finished",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e388487c-e5bd-4106-9025-e042d06b6e98", "edfea3a4-c948-4f9f-9b02-504e6cf55a02", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38173251-3785-4575-b9fb-a196fbe582fe", "bfe6aa05-d9f0-4134-87a0-eb95669d7a03", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38173251-3785-4575-b9fb-a196fbe582fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e388487c-e5bd-4106-9025-e042d06b6e98");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Finished",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a287f90e-5332-43fc-9b96-9f52173e06ec", "ce8c530c-1c45-4940-b29c-c130f5763030", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67663154-b757-48dc-b8ea-68adf73a9a37", "1dc2fdc4-225a-4c22-9f4a-b15524c5797f", "Admin", "ADMIN" });
        }
    }
}
