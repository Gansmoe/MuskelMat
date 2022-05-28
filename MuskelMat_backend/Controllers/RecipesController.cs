using MuskelMat_backend.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace MuskelMat_backend.Controllers
{
    [ApiController]
    [Route("api/recipes")]
    public class RecipesController : Controller
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IMapper _mapper;

        public RecipesController(IRecipesRepository recipesRepository, IMapper mapper)
        {
            _recipesRepository = recipesRepository;
            _mapper = mapper;
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

        [HttpPatch("{Id}")]
        public async Task<ActionResult> PatchFilm(int id, JsonPatchDocument model)
        {
            var recipes = await _recipesRepository.RecipeAsync(id);
            if (recipes == null)
            {
                return NotFound();
            }
            await _recipesRepository.UpdateRecipesAsync(recipes, model);
            var updatedFilm = await _recipesRepository.RecipeAsync(id);
            return Ok(updatedFilm);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewRecipe(CreateRecipes model)
        {
            if (ModelState.IsValid)
                try
                {
                    var recipe = _mapper.Map<Recipes>(model);
                    _recipesRepository.Add(recipe);

                    if (await _recipesRepository.SaveChangesAsync())
                    {
                        return Ok(recipe);
                    }

                }
                catch (System.Exception ex)
                {
                    return this.StatusCode(500, "Database Failure");
                }
            return BadRequest();
        }
    }
}