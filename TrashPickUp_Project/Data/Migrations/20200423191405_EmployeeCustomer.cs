using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class EmployeeCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1150c05f-a1c7-463e-9c08-f87558f2feb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5f3c2e6-8169-4e53-ad8e-f3b570bb2111");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2bcaf1c-e103-4f7f-899b-47020bf6fda5", "2c316d0b-23be-4e51-996b-178aac611450", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bb2ae2c-c9a4-4a0a-952d-b64ee5dbe62c", "6c21fd20-47d9-480f-bc5e-65420349f085", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bb2ae2c-c9a4-4a0a-952d-b64ee5dbe62c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2bcaf1c-e103-4f7f-899b-47020bf6fda5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5f3c2e6-8169-4e53-ad8e-f3b570bb2111", "fa339f8d-2c22-44bb-b616-61da0d3706e1", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1150c05f-a1c7-463e-9c08-f87558f2feb4", "4bd7f440-2243-4e6e-9aee-3055c252257d", "Customer", "CUSTOMER" });
        }
    }
}
