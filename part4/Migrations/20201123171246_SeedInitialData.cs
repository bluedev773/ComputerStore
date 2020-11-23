using Microsoft.EntityFrameworkCore.Migrations;

namespace part4.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 1, "A small and lightweight PC for basic computing tasks.", "mini1.jpg", "The Mini", 599.99m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 2, "A Business PC for professional applications.", "business1.jpg", "The Business", 799.99m });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "Description", "ImageName", "Name", "Price" },
                values: new object[] { 3, "A PC for playing all of the latest and greatest video games.", "gamer1.jpg", "The Gamer", 999.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);
        }
    }
}
