using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SeedUserOrganizerEventData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Birthdate", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1989, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "max@test.com", "Max", "Schwarz" },
                    { 2, new DateTime(1988, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "manuel@test.com", "Manuel", "Lorenz" },
                    { 3, new DateTime(1986, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "julie@test.com", "Julie", "Barnes" },
                    { 4, new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael@test.com", "Michael", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Organizer",
                columns: new[] { "UserId", "Passward" },
                values: new object[] { 1, "mypw1" });

            migrationBuilder.InsertData(
                table: "Organizer",
                columns: new[] { "UserId", "Passward" },
                values: new object[] { 2, "somepw2" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "DatePlanned", "Description", "Image", "LocationId", "MaxParticipants", "MinAge", "Name", "OrganizerId" },
                values: new object[] { 1, new DateTime(2022, 2, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "You are new in town? Join us and meet like-minded new people!", "path/to/image.jpg", 1, 20, 16, "New in town", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Organizer",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Organizer",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
