using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class suspendstartandenddateswitchedtocustomerpickupmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5f32f08-301a-4788-9c6e-0c528723bf27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c0c5da-013b-472a-98ce-8409ebc8e776");

            migrationBuilder.DropColumn(
                name: "SuspendedEndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SuspendedStartDate",
                table: "Customers");

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedEndDate",
                table: "CustomerSchedPickUps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedStartDate",
                table: "CustomerSchedPickUps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab86ab6-a48b-4f45-8b04-461c57072fac", "3e19f098-e00c-4bfc-9055-751148fc7a37", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e06644-236a-49b8-93c5-58ae4e836993", "ef06f920-1d10-4b3d-978b-afcda5bc7ee9", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e06644-236a-49b8-93c5-58ae4e836993");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab86ab6-a48b-4f45-8b04-461c57072fac");

            migrationBuilder.DropColumn(
                name: "SuspendedEndDate",
                table: "CustomerSchedPickUps");

            migrationBuilder.DropColumn(
                name: "SuspendedStartDate",
                table: "CustomerSchedPickUps");

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedEndDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspendedStartDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5f32f08-301a-4788-9c6e-0c528723bf27", "f44b7ab5-56f5-4067-ac62-df9c1e49e563", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4c0c5da-013b-472a-98ce-8409ebc8e776", "538a7ae9-a1b4-4bde-ba22-bc093e644a2b", "Customer", "CUSTOMER" });
        }
    }
}
