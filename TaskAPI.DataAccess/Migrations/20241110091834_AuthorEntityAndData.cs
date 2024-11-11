using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorEntityAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Sahasra Kesara" },
                    { 2, "Nadeera Deshan" },
                    { 3, "Viruna Fernando" },
                    { 4, "Hansi Nimasha" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2024, 11, 10, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(351), new DateTime(2024, 11, 15, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2024, 11, 10, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(373), "For Son school", new DateTime(2024, 11, 15, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(374), 0, "Get Pens" },
                    { 3, 2, new DateTime(2024, 11, 10, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(376), "For office", new DateTime(2024, 11, 15, 14, 48, 34, 146, DateTimeKind.Local).AddTicks(376), 0, "Get Files" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2024, 11, 10, 9, 57, 3, 337, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 11, 15, 9, 57, 3, 337, DateTimeKind.Local).AddTicks(6248) });
        }
    }
}
