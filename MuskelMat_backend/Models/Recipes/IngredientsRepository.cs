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

        /* public async Task<IEnumerable<Ingredients>> AllIngredientsListAsync()
        {
                return await _appDbContext.Ingredients.ToListAsync();
        } */
    }
}