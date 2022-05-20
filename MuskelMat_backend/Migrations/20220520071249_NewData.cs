using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuskelMat_backend.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Kcal = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<int>(type: "INTEGER", nullable: false),
                    MealType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 1, 565, "Lunch Middag", "Köttbullar i tomatsås med rostade grönsaker", 28 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 2, 625, "Lunch Middag", "Kalkonfilépasta med paprikapesto", 38 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 3, 553, "Lunch Middag", "Kotlett med äpple och ingefära", 37 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 4, 529, "Lunch Middag", "Renskavsgryta med gröna ärtor", 30 });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipesId",
                table: "Ingredients",
                column: "RecipesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
