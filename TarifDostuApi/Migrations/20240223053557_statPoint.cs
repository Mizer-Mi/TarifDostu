using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TarifDostuApi.Migrations
{
    /// <inheritdoc />
    public partial class statPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    EstimatedUnitPrice = table.Column<double>(type: "double precision", nullable: false),
                    Unit = table.Column<int>(type: "integer", nullable: false),
                    IsCustom = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "EstimatedUnitPrice", "IsCustom", "Name", "Type", "Unit" },
                values: new object[,]
                {
                    { 1, 0.5, false, "Tomato", 0, 0 },
                    { 2, 0.29999999999999999, false, "Onion", 0, 0 },
                    { 3, 9.9900000000000002, false, "Chicken Breast", 1, 1 },
                    { 4, 0.20000000000000001, false, "Egg", 2, 0 },
                    { 5, 0.10000000000000001, false, "Garlic", 0, 3 },
                    { 6, 0.14999999999999999, false, "Olive Oil", 3, 2 },
                    { 7, 0.75, false, "Red Pepper", 0, 0 },
                    { 8, 0.050000000000000003, false, "Rice", 4, 1 },
                    { 9, 8.5, false, "Chicken Leg", 1, 1 },
                    { 10, 0.5, false, "Parsley", 0, 4 },
                    { 11, 0.10000000000000001, false, "Lentils", 5, 1 },
                    { 12, 0.29999999999999999, false, "Cheddar Cheese", 6, 1 },
                    { 13, 10.99, false, "Ground Beef", 1, 1 },
                    { 14, 0.25, false, "Potato", 0, 0 },
                    { 15, 0.029999999999999999, false, "Flour", 9, 1 },
                    { 16, 0.14999999999999999, false, "Yogurt", 6, 1 },
                    { 17, 0.5, false, "Lemon", 7, 0 },
                    { 18, 1.0, false, "Broccoli", 0, 0 },
                    { 19, 0.20000000000000001, false, "Milk", 6, 2 },
                    { 20, 15.99, false, "Fish", 8, 1 },
                    { 21, 0.20000000000000001, false, "Butter", 3, 1 },
                    { 22, 1.0, false, "Basil", 0, 4 },
                    { 23, 0.40000000000000002, false, "Cheddar Cheese", 6, 1 },
                    { 24, 3.0, false, "Asparagus", 0, 0 },
                    { 25, 1.5, false, "Red Cabbage", 0, 0 },
                    { 26, 0.75, false, "Leek", 0, 0 },
                    { 27, 0.5, false, "Hazelnut", 10, 1 },
                    { 28, 0.75, false, "Zucchini", 0, 0 },
                    { 29, 0.59999999999999998, false, "Grapes", 7, 1 },
                    { 30, 1.0, false, "Almond", 10, 1 },
                    { 31, 0.20000000000000001, false, "Red Lentils", 5, 1 },
                    { 32, 0.29999999999999999, false, "Beans", 5, 1 },
                    { 33, 2.0, false, "Chestnut", 10, 1 },
                    { 34, 0.80000000000000004, false, "Apple", 7, 0 },
                    { 35, 0.59999999999999998, false, "Mushroom", 0, 1 },
                    { 36, 2.0, false, "Cauliflower", 0, 0 },
                    { 37, 1.2, false, "Strawberry", 7, 1 },
                    { 38, 0.40000000000000002, false, "Dried Plum", 7, 1 },
                    { 39, 0.050000000000000003, false, "Bread", 9, 1 },
                    { 40, 1.5, false, "Red Cabbage", 0, 0 },
                    { 41, 0.5, false, "Hazelnut", 10, 1 },
                    { 42, 0.59999999999999998, false, "Pumpkin Seeds", 10, 1 },
                    { 43, 0.5, false, "Lemon", 7, 0 },
                    { 44, 0.10000000000000001, false, "Garlic", 0, 3 },
                    { 45, 1.0, false, "Basil", 0, 4 },
                    { 46, 0.69999999999999996, false, "Olive", 7, 1 },
                    { 47, 0.10000000000000001, false, "Rice", 4, 1 },
                    { 48, 0.20000000000000001, false, "Kidney Beans", 5, 1 },
                    { 49, 0.10000000000000001, false, "Coffee", 11, 1 },
                    { 50, 0.050000000000000003, false, "Tea", 11, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
