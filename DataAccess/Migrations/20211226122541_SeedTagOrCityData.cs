using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedTagOrCityData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "City",
                column: "Name",
                values: new object[]
                {
                    "Berlin",
                    "Cologne",
                    "Frankfurt",
                    "Hamburg",
                    "Munich"
                });

            migrationBuilder.InsertData(
                table: "Tag",
                column: "TagName",
                values: new object[]
                {
                    "breakfast",
                    "connect",
                    "dinner",
                    "learn",
                    "socialize"
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Berlin");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Cologne");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Frankfurt");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Hamburg");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Munich");

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagName",
                keyValue: "breakfast");

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagName",
                keyValue: "connect");

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagName",
                keyValue: "dinner");

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagName",
                keyValue: "learn");

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "TagName",
                keyValue: "socialize");
        }
    }
}
