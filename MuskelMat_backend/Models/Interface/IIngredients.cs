using System;

namespace MuskelMat_backend.Models.Interface
{
    interface IIngredients
    {
        public int Id { get; set; }
        public int RecipesId { get; set; }
        public string Name { get; set; }
    }
}