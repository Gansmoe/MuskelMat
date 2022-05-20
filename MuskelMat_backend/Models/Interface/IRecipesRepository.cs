

namespace MuskelMat_backend.Models
{
    public interface IRecipesRepository
    {
        Task<IEnumerable<Recipes>> AllRecipesListAsync();
    }
}