

namespace MuskelMat_backend.Models
{
    public interface IIngredientsRepository
    {
        Task<IEnumerable<Ingredients>> AllIngredientsListAsync();
        void Add<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}