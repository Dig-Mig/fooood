using DataAcessLayer.Models;
using DataAcessLayer.Repositories;
using FOODappApplication;
using FOODappApplication.Ingredients;
using Microsoft.AspNetCore.Mvc;
namespace FOODappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientsService _ingredientsService;
        
        public IngredientsController(IIngredientsRepository ingredientsRepository)
        {
              _ingredientsService = new IngredientsService(ingredientsRepository);  
        }
        
        // GET: api/<api>
        [HttpGet]
        public async Task<IEnumerable<Ingredient>> Get()
        {
            var  ingredients = await _ingredientsService.GetIngredients();
            return ingredients;
        }

        // GET api/<api>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {   
            var ingredient = await _ingredientsService.GetIngredient(id);
            return ingredient == null ? NotFound() : Ok(ingredient);
        }

        // POST api/<api>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient =  _ingredientsService.CreateIngredient(ingredientDTO);
            return ingredient == null ? Problem() : Ok(ingredient);
        }

        // PUT api/<api>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient = await _ingredientsService.UpdateIngredientById(id, ingredientDTO);
            
            return ingredient == null ? NotFound() : Ok(ingredient);
        }

        // DELETE api/<api>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var status = await _ingredientsService.DeleteIngredientById(id);
            return status == null ? NotFound() : NoContent();
        }
    }
}
