using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuskelMat_backend.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Kcal = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<int>(type: "INTEGER", nullable: false),
                    MealType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipesId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "RecipesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 1, 565, "Lunch Middag", "Köttbullar i tomatsås med rostade grönsaker", 28 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 2, 625, "Lunch Middag", "Kalkonfilépasta med paprikapesto", 38 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 3, 553, "Lunch Middag", "Kotlett med äpple och ingefära", 37 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 4, 529, "Lunch Middag", "Renskavsgryta med gröna ärtor", 30 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 5, 539, "Lunch Middag", "Pitabröd med köttbullar och myntayoghurt", 26 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 6, 862, "Lunch Middag", "Kebabspett med rödbetshummus", 39 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 7, 653, "Lunch Middag", "Lövbiff med potatisgratäng och cosmopolitansallad", 53 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 8, 374, "Lunch Middag", "Torsk i folie med linser, soltorkade tomater och basilika", 36 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 9, 419, "Lunch Middag", "Pizza med varmrökt lax", 27 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 10, 504, "Lunch Middag", "Ugnsbakad fisk med pepparrotsost", 37 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 11, 290, "Frukost", "Kvarg med bär", 45 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 12, 424, "Frukost", "Gröt med jordnötssmör och proteinpulver", 29 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 13, 906, "Frukost", "Ägg & Bacon", 57 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 14, 339, "Frukost", "Makrill och hackat ägg", 30 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 15, 593, "Frukost", "Proteinpannkakor", 49 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 16, 533, "Frukost", "Keso med äpple och kanel", 60 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 17, 610, "Frukost", "Frukostdrink", 63 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 18, 389, "Frukost", "Äggröra och kalkon", 29 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 19, 271, "Mellanmål", "Proteinshake", 36 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 20, 80, "Mellanmål", "Kokt ägg", 7 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 21, 52, "Mellanmål", "Äpple", 1 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 22, 266, "Mellanmål", "Keso med frukt och bär", 29 });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipesId", "Kcal", "MealType", "Name", "Protein" },
                values: new object[] { 23, 157, "Mellanmål", "Kesoplättar", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 1, "Pasta", 1 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 2, "Tomatsås", 1 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 3, "Rostade grönsaker", 1 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 4, "Köttbullar", 1 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 5, "Rödlök", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 6, "Kalkonbröst", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 7, "Snackmorötter", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 8, "Pasta (Fusilli)", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 9, "Matlagningsgrädde", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 10, "Pesto paprika", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 11, "Vitlök", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 12, "Rött äpple", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 13, "Ris", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 14, "Gul lök", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 15, "Ingefära", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 16, "Soja", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 17, "Fläskkotletter", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 18, "Plommontomater", 3 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 19, "Morötter", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 20, "Gul lök", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 21, "Renskav", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 22, "Vitlök", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 23, "Soja", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 24, "Ris", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 25, "Vispgrädde", 4 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 26, "Matyoghurt", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 27, "Köttbullar", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 28, "Pitabröd", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 29, "Vitlök", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 30, "Blandsallad", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 31, "Mynta", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 32, "Citronjuice", 5 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 33, "Couscous", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 34, "Kebabspett", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 35, "Piccolinitomater", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 36, "Persilja, färsk", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 37, "Babyspenat", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 38, "Rödbetshummus", 6 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 39, "Färdig potatisgratäng", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 40, "Cosmopolitansallad", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 41, "Rödlök", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 42, "Rödvinsvinäger", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 43, "Dijonsenap", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 44, "Lövbiff", 7 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 45, "Torskfilé", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 46, "Gröna linser", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 47, "Soltorkade tomater", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 48, "Citron", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 49, "Basilika", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 50, "Olivolja", 8 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 51, "Passerade tomater", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 52, "Oregano", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 53, "Kärsbärstomater", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 54, "Färdig pizzadeg", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 55, "Västerbottenost", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 56, "Varmrökt lax", 9 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 57, "Alaska pollock", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 58, "Färsk pepparrot", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 59, "Matlagningsgrädde", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 60, "Fiskbuljongtärning", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 61, "Ris", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 62, "Mangoldskott", 10 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 63, "Kvarg", 11 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 64, "Blåbär", 11 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 65, "Hallon", 11 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 66, "Havregryn", 12 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 67, "Proteinpulver", 12 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 68, "Jordnötssmör", 12 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 69, "Mjölk", 12 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 70, "Ägg", 13 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 71, "Bacon", 13 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 72, "Mellanmjölk", 13 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 73, "Ägg", 14 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 74, "Makrill i tomatsås", 14 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 75, "Mjölk", 15 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 76, "Ägg", 15 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 77, "Vetemjöl", 15 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 78, "Proteinpulver med chokladsmak", 15 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 79, "Kakao", 15 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 80, "Keso", 16 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 81, "Äpple", 16 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 82, "Kanel", 16 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 83, "Lättmjölk", 17 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 84, "Banan", 17 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 85, "Havregryn", 17 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 86, "Proteinpulver med chokladsmak", 17 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 87, "Ägg", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 88, "Kalkonpålägg", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 89, "Babyspenat", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 90, "Avokado", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 91, "Tomat", 18 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 92, "Mellanmjölk", 19 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 93, "Proteinpulver", 19 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 94, "Ägg", 20 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 95, "Äpple", 21 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 96, "Keso", 22 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 97, "Naturell lättyoghurt", 22 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 98, "Banan", 22 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 99, "Bär", 22 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 100, "Keso", 23 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 101, "Fiberhusk", 23 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 102, "Ägg", 23 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "RecipesId" },
                values: new object[] { 103, "Smör", 23 });

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
