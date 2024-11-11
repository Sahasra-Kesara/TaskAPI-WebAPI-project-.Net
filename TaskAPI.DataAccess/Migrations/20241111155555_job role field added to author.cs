using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class jobrolefieldaddedtoauthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Frontend Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Backend Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Software Architect");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "Full Stack Developer");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 11, 16, 21, 25, 54, 901, DateTimeKind.Local).AddTicks(9783) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Authors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 11, 16, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 11, 16, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8145), new DateTime(2024, 11, 16, 16, 48, 43, 467, DateTimeKind.Local).AddTicks(8145) });
        }
    }
}
