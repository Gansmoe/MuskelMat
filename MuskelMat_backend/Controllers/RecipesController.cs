using MuskelMat_backend.Models;

using Microsoft.AspNetCore.Mvc;

namespace MuskelMat_backend.Controllers
{
    [Route("api/recipes")]
    public class RecipesController : Controller
    {
        private readonly IRecipesRepository _recipesRepository;

        public RecipesController(IRecipesRepository recipesRepository)
        {
            _recipesRepository = recipesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipes>>> GetAllAsync()
        {
            var recipes = await _recipesRepository.AllRecipesListAsync();
            if (recipes == null)
            {
                return NotFound();
            }
            return Ok(recipes);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Recipes>> GetRecipe(int id)
        {
            var recipe = await _recipesRepository.RecipeAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }
    }
}