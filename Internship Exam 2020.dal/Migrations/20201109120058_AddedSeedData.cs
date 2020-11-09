using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_Exam_2020.dal.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CreatedAt", "Email", "Name" },
                values: new object[] { 2, new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5067), "gcfdsfattrall0@cloudflare.com", "Gab" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 11, 9, 12, 0, 53, 921, DateTimeKind.Utc).AddTicks(1969), "gcattrall0@cloudflare.com", "Gabriellia" },
                    { 3, 3, new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5332), "gcattrall0@cloudfdfsflare.com", "Gabie" },
                    { 4, 4, new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5344), "gcattrallfdf0@cloudflare.com", "John" },
                    { 5, 6, new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5353), "gcattrafdfdll0@cloudflare.com", "Dave" },
                    { 6, 20, new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5363), "gcattrfddall0@cloudflare.com", "Gabriefdfdllia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CreatedAt", "Email", "Name" },
                values: new object[] { 22, new DateTime(2020, 11, 9, 10, 50, 22, 863, DateTimeKind.Utc).AddTicks(3963), "farukohran@gmail.com", "Faruk Ohran" });
        }
    }
}
