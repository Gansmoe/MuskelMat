

namespace MuskelMat_backend.Models
{
    public class RecipesRepository : IRecipesRepository
    {
        private readonly AppDbContext _appDbContext;

        public RecipesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Recipes> AllRecipes
        {
            get
            {
                return _appDbContext.Recipes;
            }
        }
    }
}