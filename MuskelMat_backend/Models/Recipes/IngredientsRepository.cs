

namespace MuskelMat_backend.Models
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly AppDbContext _appDbContext;

        public IngredientsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ingredients> AllIngredients
        {
            get
            {
                return _appDbContext.Ingredients;
            }
        }
    }
}