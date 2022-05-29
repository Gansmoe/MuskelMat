using AutoMapper;

namespace MuskelMat_backend.Models
{
    public class RecipesProfile : Profile
    {
        public RecipesProfile()
        {
            this.CreateMap<CreateRecipes, Recipes>();
        }
    }
}