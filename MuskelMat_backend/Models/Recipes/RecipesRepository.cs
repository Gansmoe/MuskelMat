using Microsoft.EntityFrameworkCore;

namespace MuskelMat_backend.Models
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly AppDbContext _appDbContext;

        public RecipesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Recipes>> AllRecipesListAsync()
        {
                return await _appDbContext.Recipes.ToListAsync();
        }
    }
}