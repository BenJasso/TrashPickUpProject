using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class CreateScheduledPickUpInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31426f3d-22f5-4228-8cce-59ab675fd11f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b268e5e-273e-4506-8f40-145a2c18d45a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7649024d-0a93-4e12-bacf-14a8b8778e67", "8d956835-a9b9-422a-93db-34436cd129de", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84ab5c75-ef44-42f4-8b50-65860734c4f6", "641bdb8c-9864-4c16-8955-42ecb4c54a8c", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7649024d-0a93-4e12-bacf-14a8b8778e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84ab5c75-ef44-42f4-8b50-65860734c4f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b268e5e-273e-4506-8f40-145a2c18d45a", "e93c31e2-3967-4c1c-9ae1-63ffbcbaaf15", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31426f3d-22f5-4228-8cce-59ab675fd11f", "194c8418-8c35-4235-a3ee-ae3aa58dd291", "Customer", "CUSTOMER" });
        }
    }
}
