using Microsoft.EntityFrameworkCore.Migrations;

namespace CretaceousPark.Migrations
{
    public partial class SeedDataThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 7, 7, "Female", "Matilda", "Woolly Mammoth" },
                    { 8, 10, "Female", "Rexie", "Dinosaur" },
                    { 9, 2, "Female", "Matilda", "Dinosaur" },
                    { 10, 4, "Male", "Pip", "Shark" },
                    { 11, 22, "Male", "Bartholomew", "Dinosaur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Female", "Matilda", "Woolly Mammoth" },
                    { 2, 10, "Female", "Rexie", "Dinosaur" },
                    { 3, 2, "Female", "Matilda", "Dinosaur" },
                    { 4, 4, "Male", "Pip", "Shark" },
                    { 5, 22, "Male", "Bartholomew", "Dinosaur" }
                });
        }
    }
}
