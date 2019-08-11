using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBulder.Infa.Data.Migrations
{
    public partial class Initiator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2fb3da-75a4-4903-8242-fee98a285376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edeba54b-454e-44c8-b333-6c4519f37a24");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Projects",
                newName: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InitiatorId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ddf998e-1f92-4781-bda2-7f21043a0fc7", "9d39b869-b348-46b0-99c0-a803e7c3504e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d2ffae9-9ab9-4324-80c3-ca702d8ac67f", "16383bb5-7627-4fc7-809a-87589699fca2", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_InitiatorId",
                table: "Projects",
                column: "InitiatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_InitiatorId",
                table: "Projects",
                column: "InitiatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_InitiatorId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_InitiatorId",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d2ffae9-9ab9-4324-80c3-ca702d8ac67f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ddf998e-1f92-4781-bda2-7f21043a0fc7");

            migrationBuilder.DropColumn(
                name: "InitiatorId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Projects",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed2fb3da-75a4-4903-8242-fee98a285376", "10660fe4-d9ea-4942-9cec-0171e6bfcadc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edeba54b-454e-44c8-b333-6c4519f37a24", "ed8ee48a-734c-4c0f-be90-4a51f0503143", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_UserId",
                table: "Projects",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
