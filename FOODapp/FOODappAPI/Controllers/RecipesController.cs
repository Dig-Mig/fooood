using DataAcessLayer.Data;
using FOODappApplication.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace FOODappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
     
        
        
        // POST api/<api>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RecipeDTO recipeDTO)
        {
            var recipe =  _recipeService.CreateRecipe(recipeDTO);
            return recipe == null ? Problem() : Ok(recipe);
        }
    }
}