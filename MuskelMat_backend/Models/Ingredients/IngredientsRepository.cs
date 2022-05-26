using Microsoft.EntityFrameworkCore;

namespace MuskelMat_backend.Models
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly AppDbContext _appDbContext;

        public IngredientsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Ingredients>> AllIngredientsListAsync()
        {
            return await _appDbContext.Ingredients.ToListAsync();
        }

        public void Add<T>(T entity) where T : class
        {
            _appDbContext.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _appDbContext.SaveChangesAsync()) > 0;
        }
    }
}