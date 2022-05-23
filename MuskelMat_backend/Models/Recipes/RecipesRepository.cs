using Microsoft.EntityFrameworkCore;
using System.Linq;

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
                return await _appDbContext.Recipes.Include(i => i.Ingredients).ToListAsync();
        }

        public async Task<Recipes> RecipeAsync(int id)
        {
            IQueryable<Recipes> query = _appDbContext.Recipes.Where(r => r.RecipesId == id);

            Recipes recipe = await query.FirstOrDefaultAsync();
            recipe.Ingredients = _appDbContext.Ingredients.Where(i => i.RecipesId == recipe.RecipesId).ToList();

            return recipe;
        }
    }
}