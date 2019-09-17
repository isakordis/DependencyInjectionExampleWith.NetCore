using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DependencyInjectionExample.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "Genre", "Price", "PublishDate", "Title" },
                values: new object[] { 4, "Genre1", 20m, new DateTime(2012, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book1" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "id", "Genre", "Price", "PublishDate", "Title" },
                values: new object[] { 2, "Genre2", 30m, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
