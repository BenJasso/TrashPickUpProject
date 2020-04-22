using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec5dbf67-34c1-4577-82ab-519bb1786ab7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20477566-3c56-4d4d-b0ad-53ab2acb2265", "e8f363b6-1215-4bbf-a934-60c9dc04b876", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20477566-3c56-4d4d-b0ad-53ab2acb2265");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec5dbf67-34c1-4577-82ab-519bb1786ab7", "fc1c72c8-7df0-4936-a2eb-33ce20190d50", "Employee", "EMPLOYEE" });
        }
    }
}
