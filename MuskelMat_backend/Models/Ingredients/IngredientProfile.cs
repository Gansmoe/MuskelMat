using AutoMapper;

namespace MuskelMat_backend.Models
{
    public class IngredientsProfile : Profile
    {
        public IngredientsProfile()
        {
            this.CreateMap<CreateIngredients, Ingredients>();
        }
    }
}