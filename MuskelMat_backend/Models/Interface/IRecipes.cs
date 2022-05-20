using System;

namespace MuskelMat_backend.Models.Interface
{
    interface IRecipes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kcal { get; set; }
        public int Protein { get; set; }
        public string MealType { get; set; }
        public List<Ingredients> Ingredients { get; set; }
    }
}
