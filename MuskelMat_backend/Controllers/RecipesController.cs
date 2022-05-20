using MuskelMat_backend.Models;

using Microsoft.AspNetCore.Mvc;

namespace MuskelMat_backend.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipesRepository _recipesRepository;

        public RecipesController(IRecipesRepository recipesRepository)
        {
            _recipesRepository = recipesRepository;
        }
    }
}