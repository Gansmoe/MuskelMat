using Microsoft.EntityFrameworkCore;

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

            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 1,
                Name = "Köttbullar i tomatsås med rostade grönsaker",
                Kcal = 565,
                Protein = 28,
                MealType = "Lunch Middag",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 2,
                Name = "Kalkonfilépasta med paprikapesto",
                Kcal = 625,
                Protein = 38,
                MealType = "Lunch Middag",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 3,
                Name = "Kotlett med äpple och ingefära",
                Kcal = 553,
                Protein = 37,
                MealType = "Lunch Middag",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 4,
                Name = "Renskavsgryta med gröna ärtor",
                Kcal = 529,
                Protein = 30,
                MealType = "Lunch Middag",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 5,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 6,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 7,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 8,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 9,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 10,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 11,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 12,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 13,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 14,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 15,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 16,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 17,
                Name = "",
                Kcal = ,
                Protein = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 18,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 19,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 20,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 21,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 22,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 23,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 24,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 25,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 26,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 27,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 28,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });
            builder.Entity<Recipes>().HasData(new Recipes
            {
                Id = 29,
                Name = "",
                Kcal = ,
                Protein = ,
                MealType = "",
                Ingredients = {},
            });

        }

    }
}