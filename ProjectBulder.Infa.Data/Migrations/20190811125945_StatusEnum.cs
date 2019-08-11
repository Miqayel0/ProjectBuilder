using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class StatusEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DonatedCount",
                table: "Projects",
                newName: "DonationsCount");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Projects",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a287f90e-5332-43fc-9b96-9f52173e06ec", "ce8c530c-1c45-4940-b29c-c130f5763030", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67663154-b757-48dc-b8ea-68adf73a9a37", "1dc2fdc4-225a-4c22-9f4a-b15524c5797f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67663154-b757-48dc-b8ea-68adf73a9a37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a287f90e-5332-43fc-9b96-9f52173e06ec");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "DonationsCount",
                table: "Projects",
                newName: "DonatedCount");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b67fb53-1501-4ebb-8358-718b7b6c6fff", "7f7392ae-af35-456b-aa7c-91016fa1ccb6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54c3672d-208d-4fd7-a7ad-22a85c89edd9", "5d378042-0151-4932-84b7-079265d96ebf", "Admin", "ADMIN" });
        }
    }
}
