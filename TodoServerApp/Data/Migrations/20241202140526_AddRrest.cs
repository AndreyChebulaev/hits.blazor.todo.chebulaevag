using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRrest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 19, 5, 26, 346, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 19, 5, 26, 346, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 19, 5, 26, 346, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 19, 5, 26, 346, DateTimeKind.Local).AddTicks(6191));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 16, 42, 23, 378, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 16, 42, 23, 378, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 16, 42, 23, 378, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 12, 2, 16, 42, 23, 378, DateTimeKind.Local).AddTicks(5369));
        }
    }
}
