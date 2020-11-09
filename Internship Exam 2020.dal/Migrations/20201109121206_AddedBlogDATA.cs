using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_Exam_2020.dal.Migrations
{
    public partial class AddedBlogDATA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PublishingDate" },
                values: new object[] { new DateTime(2020, 11, 9, 12, 12, 3, 437, DateTimeKind.Utc).AddTicks(8582), new DateTime(2020, 11, 9, 12, 12, 3, 437, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Content", "CreatedAt", "PublishingDate", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9607), new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9653), "NJDNJKNFKJSDNKDS", "First Title", 2 },
                    { 3, null, new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9866), new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9875), "NJDNJKNFKJSDNKDS", "First Title", 3 },
                    { 4, null, new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9889), new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9894), "NJDNJKNFKJSDNKDS", "First Title", 5 },
                    { 5, null, new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9904), new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9910), "NJDNJKNFKJSDNKDS", "First Title", 2 },
                    { 6, null, new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9919), new DateTime(2020, 11, 9, 12, 12, 3, 438, DateTimeKind.Utc).AddTicks(9925), "NJDNJKNFKJSDNKDS", "First Title", 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 429, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 430, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 430, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 430, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 430, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 9, 12, 12, 3, 430, DateTimeKind.Utc).AddTicks(5610));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PublishingDate" },
                values: new object[] { new DateTime(2020, 11, 9, 12, 6, 9, 667, DateTimeKind.Utc).AddTicks(6639), new DateTime(2020, 11, 9, 12, 6, 9, 667, DateTimeKind.Utc).AddTicks(6701) });

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
    }
}
