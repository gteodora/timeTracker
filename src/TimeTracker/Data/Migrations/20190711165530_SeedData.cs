using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "id", "name" },
                values: new object[] { 1L, "Client 1" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "id", "name" },
                values: new object[] { 2L, "Client 2" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "id", "Clientid", "name" },
                values: new object[] { 3L, 3L, "Project 3" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "HourRate", "name" },
                values: new object[] { 1L, 15m, "User 1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "HourRate", "name" },
                values: new object[] { 2L, 20m, "User 2" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "id", "Clientid", "name" },
                values: new object[] { 1L, 1L, "Project 1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "id", "Clientid", "name" },
                values: new object[] { 2L, 2L, "Project 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
