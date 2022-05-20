using System;
using MuskelMat_backend.Models.Interface;

namespace MuskelMat_backend.Models
{
    public class Ingredients : IIngredients
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}