using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class EmployeeCreateUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e06644-236a-49b8-93c5-58ae4e836993");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab86ab6-a48b-4f45-8b04-461c57072fac");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ZipCode",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cdab3e9-b27c-495e-9c53-c4fa4ac014ec", "1da6a921-12ba-4027-9be3-6b9fc3bc1631", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e0b8c8c-e705-43bf-9bda-b05c04872da8", "90fd0366-7c95-4699-bcc4-c72e52515a52", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cdab3e9-b27c-495e-9c53-c4fa4ac014ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e0b8c8c-e705-43bf-9bda-b05c04872da8");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab86ab6-a48b-4f45-8b04-461c57072fac", "3e19f098-e00c-4bfc-9055-751148fc7a37", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e06644-236a-49b8-93c5-58ae4e836993", "ef06f920-1d10-4b3d-978b-afcda5bc7ee9", "Customer", "CUSTOMER" });
        }
    }
}
