using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class EmployeeUserSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20477566-3c56-4d4d-b0ad-53ab2acb2265");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5f3c2e6-8169-4e53-ad8e-f3b570bb2111", "fa339f8d-2c22-44bb-b616-61da0d3706e1", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1150c05f-a1c7-463e-9c08-f87558f2feb4", "4bd7f440-2243-4e6e-9aee-3055c252257d", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "20477566-3c56-4d4d-b0ad-53ab2acb2265", "e8f363b6-1215-4bbf-a934-60c9dc04b876", "Admin", "ADMIN" });
        }
    }
}
