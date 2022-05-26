using Microsoft.AspNetCore.JsonPatch;

namespace MuskelMat_backend.Models
{
    public interface IRecipesRepository
    {

        void Add<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<Recipes>> AllRecipesListAsync();
        Task<Recipes> RecipeAsync(int id);
        Task UpdateRecipesAsync(Recipes recipe, JsonPatchDocument model);
    }
}