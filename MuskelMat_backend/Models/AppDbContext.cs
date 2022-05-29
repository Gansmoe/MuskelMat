using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MuskelMat_backend.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) => this.Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite(@"Data Source=C:\Users\Isac\Documents\Skola\Moderna Webbsystem\Submits\MuskelMat\MuskelMat_backend\DB\app.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Recipes>().HasMany<Ingredients>(e => e.Ingredients);

            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 1,
                Name = "Köttbullar i tomatsås med rostade grönsaker",
                Kcal = 565,
                Protein = 28,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 1, Name = "Pasta" },
                new Ingredients { Id = 2, RecipesId = 1, Name = "Tomatsås" },
                new Ingredients { Id = 3, RecipesId = 1, Name = "Rostade grönsaker" },
                new Ingredients { Id = 4, RecipesId = 1, Name = "Köttbullar" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 2,
                Name = "Kalkonfilépasta med paprikapesto",
                Kcal = 625,
                Protein = 38,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 5, RecipesId = 2, Name = "Rödlök" },
                new Ingredients { Id = 6, RecipesId = 2, Name = "Kalkonbröst" },
                new Ingredients { Id = 7, RecipesId = 2, Name = "Snackmorötter" },
                new Ingredients { Id = 8, RecipesId = 2, Name = "Pasta (Fusilli)" },
                new Ingredients { Id = 9, RecipesId = 2, Name = "Matlagningsgrädde" },
                new Ingredients { Id = 10, RecipesId = 2, Name = "Pesto paprika" },
                new Ingredients { Id = 11, RecipesId = 2, Name = "Vitlök" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 3,
                Name = "Kotlett med äpple och ingefära",
                Kcal = 553,
                Protein = 37,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 12, RecipesId = 3, Name = "Rött äpple" },
                new Ingredients { Id = 13, RecipesId = 3, Name = "Ris" },
                new Ingredients { Id = 14, RecipesId = 3, Name = "Gul lök" },
                new Ingredients { Id = 15, RecipesId = 3, Name = "Ingefära" },
                new Ingredients { Id = 16, RecipesId = 3, Name = "Soja" },
                new Ingredients { Id = 17, RecipesId = 3, Name = "Fläskkotletter" },
                new Ingredients { Id = 18, RecipesId = 3, Name = "Plommontomater" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 4,
                Name = "Renskavsgryta med gröna ärtor",
                Kcal = 529,
                Protein = 30,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 19, RecipesId = 4, Name = "Morötter" },
                new Ingredients { Id = 20, RecipesId = 4, Name = "Gul lök" },
                new Ingredients { Id = 21, RecipesId = 4, Name = "Renskav" },
                new Ingredients { Id = 22, RecipesId = 4, Name = "Vitlök" },
                new Ingredients { Id = 23, RecipesId = 4, Name = "Soja" },
                new Ingredients { Id = 24, RecipesId = 4, Name = "Ris" },
                new Ingredients { Id = 25, RecipesId = 4, Name = "Vispgrädde" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 5,
                Name = "Pitabröd med köttbullar och myntayoghurt",
                Kcal = 539,
                Protein = 26,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 26, RecipesId = 5, Name = "Matyoghurt" },
                new Ingredients { Id = 27, RecipesId = 5, Name = "Köttbullar" },
                new Ingredients { Id = 28, RecipesId = 5, Name = "Pitabröd" },
                new Ingredients { Id = 29, RecipesId = 5, Name = "Vitlök" },
                new Ingredients { Id = 30, RecipesId = 5, Name = "Blandsallad" },
                new Ingredients { Id = 31, RecipesId = 5, Name = "Mynta" },
                new Ingredients { Id = 32, RecipesId = 5, Name = "Citronjuice" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 6,
                Name = "Kebabspett med rödbetshummus",
                Kcal = 862,
                Protein = 39,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 33, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 34, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 35, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 36, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 37, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 38, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 7,
                Name = "Lövbiff med potatisgratäng och cosmopolitansallad",
                Kcal = 653,
                Protein = 53,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 39, RecipesId = 7, Name = "Färdig potatisgratäng" },
                new Ingredients { Id = 40, RecipesId = 7, Name = "Cosmopolitansallad" },
                new Ingredients { Id = 41, RecipesId = 7, Name = "Rödlök" },
                new Ingredients { Id = 42, RecipesId = 7, Name = "Rödvinsvinäger" },
                new Ingredients { Id = 43, RecipesId = 7, Name = "Dijonsenap" },
                new Ingredients { Id = 44, RecipesId = 7, Name = "Lövbiff" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 8,
                Name = "Torsk i folie med linser, soltorkade tomater och basilika",
                Kcal = 374,
                Protein = 36,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 45, RecipesId = 8, Name = "Torskfilé" },
                new Ingredients { Id = 46, RecipesId = 8, Name = "Gröna linser" },
                new Ingredients { Id = 47, RecipesId = 8, Name = "Soltorkade tomater" },
                new Ingredients { Id = 48, RecipesId = 8, Name = "Citron" },
                new Ingredients { Id = 49, RecipesId = 8, Name = "Basilika" },
                new Ingredients { Id = 50, RecipesId = 8, Name = "Olivolja" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 9,
                Name = "Pizza med varmrökt lax",
                Kcal = 419,
                Protein = 27,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 51, RecipesId = 9, Name = "Passerade tomater" },
                new Ingredients { Id = 52, RecipesId = 9, Name = "Oregano" },
                new Ingredients { Id = 53, RecipesId = 9, Name = "Kärsbärstomater" },
                new Ingredients { Id = 54, RecipesId = 9, Name = "Färdig pizzadeg" },
                new Ingredients { Id = 55, RecipesId = 9, Name = "Västerbottenost" },
                new Ingredients { Id = 56, RecipesId = 9, Name = "Varmrökt lax" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 10,
                Name = "Ugnsbakad fisk med pepparrotsost",
                Kcal = 504,
                Protein = 37,
                MealType = "Lunch Middag",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 57, RecipesId = 10, Name = "Alaska pollock" },
                new Ingredients { Id = 58, RecipesId = 10, Name = "Färsk pepparrot" },
                new Ingredients { Id = 59, RecipesId = 10, Name = "Matlagningsgrädde" },
                new Ingredients { Id = 60, RecipesId = 10, Name = "Fiskbuljongtärning" },
                new Ingredients { Id = 61, RecipesId = 10, Name = "Ris" },
                new Ingredients { Id = 62, RecipesId = 10, Name = "Mangoldskott" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 11,
                Name = "Kvarg med bär",
                Kcal = 290,
                Protein = 45,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 63, RecipesId = 11, Name = "Kvarg" },
                new Ingredients { Id = 64, RecipesId = 11, Name = "Blåbär" },
                new Ingredients { Id = 65, RecipesId = 11, Name = "Hallon" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 12,
                Name = "Gröt med jordnötssmör och proteinpulver",
                Kcal = 424,
                Protein = 29,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 66, RecipesId = 12, Name = "Havregryn" },
                new Ingredients { Id = 67, RecipesId = 12, Name = "Proteinpulver" },
                new Ingredients { Id = 68, RecipesId = 12, Name = "Jordnötssmör" },
                new Ingredients { Id = 69, RecipesId = 12, Name = "Mjölk" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 13,
                Name = "Ägg & Bacon",
                Kcal = 906,
                Protein = 57,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 70, RecipesId = 13, Name = "Ägg" },
                new Ingredients { Id = 71, RecipesId = 13, Name = "Bacon" },
                new Ingredients { Id = 72, RecipesId = 13, Name = "Mellanmjölk" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 14,
                Name = "Makrill och hackat ägg",
                Kcal = 339,
                Protein = 30,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 73, RecipesId = 14, Name = "Ägg" },
                new Ingredients { Id = 74, RecipesId = 14, Name = "Makrill i tomatsås" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 15,
                Name = "Proteinpannkakor",
                Kcal = 593,
                Protein = 49,
                MealType = "Frukost",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 75, RecipesId = 15, Name = "Mjölk" },
                new Ingredients { Id = 76, RecipesId = 15, Name = "Ägg" },
                new Ingredients { Id = 77, RecipesId = 15, Name = "Vetemjöl" },
                new Ingredients { Id = 78, RecipesId = 15, Name = "Proteinpulver med chokladsmak" },
                new Ingredients { Id = 79, RecipesId = 15, Name = "Kakao" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 16,
                Name = "Keso med äpple och kanel",
                Kcal = 533,
                Protein = 60,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 80, RecipesId = 16, Name = "Keso" },
                new Ingredients { Id = 81, RecipesId = 16, Name = "Äpple" },
                new Ingredients { Id = 82, RecipesId = 16, Name = "Kanel" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 17,
                Name = "Frukostdrink",
                Kcal = 610,
                Protein = 63,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 83, RecipesId = 17, Name = "Lättmjölk" },
                new Ingredients { Id = 84, RecipesId = 17, Name = "Banan" },
                new Ingredients { Id = 85, RecipesId = 17, Name = "Havregryn" },
                new Ingredients { Id = 86, RecipesId = 17, Name = "Proteinpulver med chokladsmak" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 18,
                Name = "Äggröra och kalkon",
                Kcal = 389,
                Protein = 29,
                MealType = "Frukost",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 87, RecipesId = 18, Name = "Ägg" },
                new Ingredients { Id = 88, RecipesId = 18, Name = "Kalkonpålägg" },
                new Ingredients { Id = 89, RecipesId = 18, Name = "Babyspenat" },
                new Ingredients { Id = 90, RecipesId = 18, Name = "Avokado" },
                new Ingredients { Id = 91, RecipesId = 18, Name = "Tomat" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 19,
                Name = "Proteinshake",
                Kcal = 271,
                Protein = 36,
                MealType = "Mellanmål",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 92, RecipesId = 19, Name = "Mellanmjölk" },
                new Ingredients { Id = 93, RecipesId = 19, Name = "Proteinpulver" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 20,
                Name = "Kokt ägg",
                Kcal = 80,
                Protein = 7,
                MealType = "Mellanmål",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 94, RecipesId = 20, Name = "Ägg" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 21,
                Name = "Äpple",
                Kcal = 52,
                Protein = 1,
                MealType = "Mellanmål",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 95, RecipesId = 21, Name = "Äpple" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 22,
                Name = "Keso med frukt och bär",
                Kcal = 266,
                Protein = 29,
                MealType = "Mellanmål",
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 96, RecipesId = 22, Name = "Keso" },
                new Ingredients { Id = 97, RecipesId = 22, Name = "Naturell lättyoghurt" },
                new Ingredients { Id = 98, RecipesId = 22, Name = "Banan" },
                new Ingredients { Id = 99, RecipesId = 22, Name = "Bär" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 23,
                Name = "Kesoplättar",
                Kcal = 157,
                Protein = 18,
                MealType = "Mellanmål",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 100, RecipesId = 23, Name = "Keso" },
                new Ingredients { Id = 101, RecipesId = 23, Name = "Fiberhusk" },
                new Ingredients { Id = 102, RecipesId = 23, Name = "Ägg" },
                new Ingredients { Id = 103, RecipesId = 23, Name = "Smör" }
            );
            /* builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 24,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 25,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 26,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 27,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 28,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            );
            builder.Entity<Recipes>().HasData(new Recipes
            {
                RecipesId = 29,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Ingredients>().HasData(
                new Ingredients { Id = 1, RecipesId = 6, Name = "Couscous" },
                new Ingredients { Id = 2, RecipesId = 6, Name = "Kebabspett" },
                new Ingredients { Id = 3, RecipesId = 6, Name = "Piccolinitomater" },
                new Ingredients { Id = 4, RecipesId = 6, Name = "Persilja, färsk" },
                new Ingredients { Id = 5, RecipesId = 6, Name = "Babyspenat" },
                new Ingredients { Id = 6, RecipesId = 6, Name = "Rödbetshummus" }
            ); */

        }

    }
}