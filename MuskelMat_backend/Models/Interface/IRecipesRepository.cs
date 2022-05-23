

namespace MuskelMat_backend.Models
{
    public interface IRecipesRepository
    {
        Task<IEnumerable<Recipes>> AllRecipesListAsync();
        Task<Recipes> RecipeAsync(int id);
    }
}