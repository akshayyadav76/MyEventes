using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedEventTagOrEventUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventTag",
                columns: new[] { "EventId", "TagId", "Id" },
                values: new object[,]
                {
                    { 1, "connect", 2 },
                    { 1, "dinner", 3 },
                    { 1, "socialize", 1 }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId", "Id" },
                values: new object[,]
                {
                    { 1, 3, 13 },
                    { 1, 4, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventTag",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { 1, "connect" });

            migrationBuilder.DeleteData(
                table: "EventTag",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { 1, "dinner" });

            migrationBuilder.DeleteData(
                table: "EventTag",
                keyColumns: new[] { "EventId", "TagId" },
                keyValues: new object[] { 1, "socialize" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, 4 });
        }
    }
}
