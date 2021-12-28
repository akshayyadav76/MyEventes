using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedLocationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "CityName", "HouseNumber", "PostalCode", "Street", "Title" },
                values: new object[,]
                {
                    { 1, "Munich", "5A", "80135", "Beerstreet", "Beerhall" },
                    { 2, "Munich", "10", "81035", "Beerstreet", null },
                    { 3, "Munich", "101", "80031", "Gardenstreet", null },
                    { 4, "Berlin", "12", "12141", "Veggiestreet", "The Green One" },
                    { 5, "Berlin", "1", "11011", "Park Plaza", null },
                    { 6, "Cologne", "3", "12345", "Carnevalstreet", "Partyhouse" },
                    { 7, "Hamburg", "18", "72657", "Some", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
