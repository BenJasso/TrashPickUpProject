using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class customeraddressinfoadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b5b89f3-19ba-444e-8334-07e85bd8326e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8cda87-d01d-400b-a87b-9af2142de251");

            migrationBuilder.AlterColumn<double>(
                name: "ZipCode",
                table: "CustomerSchedPickUps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DayOfWeek",
                table: "CustomerSchedPickUps",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "CustomerSchedPickUps",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedEndDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedStartDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "ZipCode",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fbd2f46-6627-4a4d-9f92-fbdbb091c9f4", "3679de5a-fa74-4e33-89d5-c241926f571d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6aa28d03-b085-4631-9490-18fed8016b80", "ec7f653d-6395-44a6-88af-05109b812ded", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fbd2f46-6627-4a4d-9f92-fbdbb091c9f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa28d03-b085-4631-9490-18fed8016b80");

            migrationBuilder.DropColumn(
                name: "City",
                table: "CustomerSchedPickUps");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendedEndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendedStartDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "CustomerSchedPickUps",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "DayOfWeek",
                table: "CustomerSchedPickUps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e8cda87-d01d-400b-a87b-9af2142de251", "8abe888e-336e-4ac9-b9d5-a87012d43078", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b5b89f3-19ba-444e-8334-07e85bd8326e", "34025b67-6c03-4d10-8089-80964b6a0a20", "Customer", "CUSTOMER" });
        }
    }
}
