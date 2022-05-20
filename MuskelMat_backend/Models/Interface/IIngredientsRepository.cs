

namespace MuskelMat_backend.Models
{
    public interface IIngredientsRepository
    {
        Task<IEnumerable<Ingredients>> AllIngredientsListAsync();
    }
}