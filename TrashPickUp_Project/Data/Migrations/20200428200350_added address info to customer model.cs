using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashPickUp_Project.Data.Migrations
{
    public partial class addedaddressinfotocustomermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fbd2f46-6627-4a4d-9f92-fbdbb091c9f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa28d03-b085-4631-9490-18fed8016b80");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5f32f08-301a-4788-9c6e-0c528723bf27", "f44b7ab5-56f5-4067-ac62-df9c1e49e563", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4c0c5da-013b-472a-98ce-8409ebc8e776", "538a7ae9-a1b4-4bde-ba22-bc093e644a2b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5f32f08-301a-4788-9c6e-0c528723bf27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c0c5da-013b-472a-98ce-8409ebc8e776");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fbd2f46-6627-4a4d-9f92-fbdbb091c9f4", "3679de5a-fa74-4e33-89d5-c241926f571d", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6aa28d03-b085-4631-9490-18fed8016b80", "ec7f653d-6395-44a6-88af-05109b812ded", "Customer", "CUSTOMER" });
        }
    }
}
