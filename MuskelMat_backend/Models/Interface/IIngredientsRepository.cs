

namespace MuskelMat_backend.Models
{
    public interface IIngredientsRepository
    {
        IEnumerable<Ingredients> AllIngredients { get; }
    }
}