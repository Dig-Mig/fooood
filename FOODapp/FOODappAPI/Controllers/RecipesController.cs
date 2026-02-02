using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;
using FOODappApplication.Recipes;
using Microsoft.AspNetCore.Mvc;

namespace FOODappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        private readonly IMapper _mapper;

        public RecipesController(IRecipeRepository recipeRepository , IMapper mapper)
        {
            _recipeService = new RecipeService(recipeRepository);
            _mapper = mapper;
        }
        
        // GET api/<api>
        [HttpGet]
        public async Task<IEnumerable<RecipeDTO>> Get()
        {
            var recipes = await _recipeService.GetRecipes();
            var dto = _mapper.Map<IEnumerable<RecipeDTO>>(recipes);
            return dto;
        }

        // GET api/<api>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var recipe = _recipeService.GetRecipe(id);
            return recipe == null ? Problem() : Ok(recipe);
        }
        
        // POST api/<api>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RecipeDTO recipeDTO)
        {
            var recipe =  _recipeService.CreateRecipe(recipeDTO);
            return recipe == null ? Problem() : Ok(recipe);
        }

        // Put api/<api>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RecipeDTO recipeDTO)
        {
            var recipe = await _recipeService.UpdateRecipeById(id, recipeDTO);
            return recipe == null ? Problem() : Ok(recipeDTO);
        }

        // DELETE api/<api>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var status = await _recipeService.DeleteRecipeById(id);
            return status == null ? NotFound() : NoContent();
        }
    }
}