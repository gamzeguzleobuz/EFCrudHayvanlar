using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCrud.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hayvanlar",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Kedi" },
                    { 2, "Köpek" },
                    { 3, "Aslan" },
                    { 4, "Kuş" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hayvanlar",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
