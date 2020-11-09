using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_Exam_2020.dal.Migrations
{
    public partial class AddedBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedAt", "PublishingDate", "Summary", "Title", "UserId" },
                values: new object[] { 1, null, new DateTime(2020, 11, 9, 12, 6, 9, 667, DateTimeKind.Utc).AddTicks(6639), new DateTime(2020, 11, 9, 12, 6, 9, 667, DateTimeKind.Utc).AddTicks(6701), "NJDNJKNFKJSDNKDS", "First Title", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 656, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 658, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 658, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 658, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 658, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 6, 9, 658, DateTimeKind.Utc).AddTicks(2348));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 921, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 0, 53, 922, DateTimeKind.Utc).AddTicks(5363));
        }
    }
}
