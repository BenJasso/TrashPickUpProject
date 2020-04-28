using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class CreateCustomerScheduledPickUps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7649024d-0a93-4e12-bacf-14a8b8778e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ab5c75-ef44-42f4-8b50-65860734c4f6");

            migrationBuilder.CreateTable(
                name: "CustomerSchedPickUps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    DayOfWeek = table.Column<string>(nullable: true),
                    OneTimePickUp = table.Column<DateTime>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSchedPickUps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSchedPickUps_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9cac065-7cd9-440c-b951-d5f8f1e81568", "7cc59e29-970b-47c4-ac66-55840320bac3", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ebe18ed-d9eb-4ee4-a368-7f7e40997296", "cbb259e8-d64a-4fa1-9431-8788e5a2399b", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSchedPickUps_IdentityUserId",
                table: "CustomerSchedPickUps",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerSchedPickUps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ebe18ed-d9eb-4ee4-a368-7f7e40997296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9cac065-7cd9-440c-b951-d5f8f1e81568");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7649024d-0a93-4e12-bacf-14a8b8778e67", "8d956835-a9b9-422a-93db-34436cd129de", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84ab5c75-ef44-42f4-8b50-65860734c4f6", "641bdb8c-9864-4c16-8955-42ecb4c54a8c", "Customer", "CUSTOMER" });
        }
    }
}
