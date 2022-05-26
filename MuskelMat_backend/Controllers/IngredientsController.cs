using MuskelMat_backend.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


namespace MuskelMat_backend.Controllers
{
    [Route("api/ingredients")]
    public class IngredientsController : Controller
    {
        private readonly IIngredientsRepository _ingredientsRepository;
        private readonly IMapper _mapper;

        public IngredientsController(IIngredientsRepository ingredientsRepository, IMapper mapper)
        {
            _ingredientsRepository = ingredientsRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> AddNewIngredients(CreateIngredients model)
        {
            if (ModelState.IsValid)
                try
                {
                        var ingredient = _mapper.Map<Ingredients>(model);
                        _ingredientsRepository.Add(ingredient);

                    if (await _ingredientsRepository.SaveChangesAsync())
                    {
                        return Ok(_ingredientsRepository.AllIngredientsListAsync());
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