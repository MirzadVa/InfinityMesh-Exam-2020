using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_Exam_2020.dal.Migrations
{
    public partial class addedOneMoreUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "Email", "Name" },
                values: new object[] { 2, 22, new DateTime(2020, 11, 9, 10, 50, 22, 863, DateTimeKind.Utc).AddTicks(3963), "farukohran@gmail.com", "Faruk Ohran" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "Email", "Name" },
                values: new object[] { 1, 22, new DateTime(2020, 11, 9, 10, 41, 0, 181, DateTimeKind.Utc).AddTicks(8823), "varupamirzad@gmail.com", "Mirzad Varupa" });
        }
    }
}
