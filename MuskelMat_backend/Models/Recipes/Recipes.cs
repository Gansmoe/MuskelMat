using System;
using MuskelMat_backend.Models.Interface;

namespace MuskelMat_backend.Models
{
    public class Recipes : IRecipes
    {
        public int RecipesId { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public int Protein { get; set; }
        public string MealType { get; set; }
        public List<Ingredients> Ingredients { get; set; }
    }
}