

namespace MuskelMat_backend.Models
{
    public interface IRecipesRepository
    {
        IEnumerable<Recipes> AllRecipes { get; }
    }
}