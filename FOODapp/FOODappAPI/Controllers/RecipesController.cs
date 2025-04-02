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
        
    }
}