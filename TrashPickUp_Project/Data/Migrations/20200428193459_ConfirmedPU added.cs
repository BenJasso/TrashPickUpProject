using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class ConfirmedPUadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ebe18ed-d9eb-4ee4-a368-7f7e40997296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9cac065-7cd9-440c-b951-d5f8f1e81568");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "ConfirmedPUs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmedPUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfirmedPUs_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e8cda87-d01d-400b-a87b-9af2142de251", "8abe888e-336e-4ac9-b9d5-a87012d43078", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b5b89f3-19ba-444e-8334-07e85bd8326e", "34025b67-6c03-4d10-8089-80964b6a0a20", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_ConfirmedPUs_IdentityUserId",
                table: "ConfirmedPUs",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfirmedPUs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b5b89f3-19ba-444e-8334-07e85bd8326e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8cda87-d01d-400b-a87b-9af2142de251");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9cac065-7cd9-440c-b951-d5f8f1e81568", "7cc59e29-970b-47c4-ac66-55840320bac3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ebe18ed-d9eb-4ee4-a368-7f7e40997296", "cbb259e8-d64a-4fa1-9431-8788e5a2399b", "Customer", "CUSTOMER" });
        }
    }
}
