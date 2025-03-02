using DataAcessLayer.Data;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;
using FOODappApplication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace FOODappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private IIngredientsService _ingredientsService;
        
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
        public void Post([FromBody] IngredioentDTO ingredientDTO)
        {
            _ingredientsService.CreateIngredient(ingredientDTO);
        }

        // PUT api/<api>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] IngredioentDTO ingredientDTO)
        {
            var status = await _ingredientsService.UpdateIngredientById(id, ingredientDTO);
            
            return status == null ? NotFound() : Ok(status);
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
