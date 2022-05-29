using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.JsonPatch;
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

        public void Add<T>(T entity) where T : class
        {
            _appDbContext.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _appDbContext.SaveChangesAsync()) > 0;
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

        public async Task UpdateRecipesAsync(Recipes recipe, JsonPatchDocument model)
        {
            model.ApplyTo(recipe);
            await _appDbContext.SaveChangesAsync();
        }


    }
}