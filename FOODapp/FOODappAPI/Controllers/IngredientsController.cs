using AutoMapper;
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
        private readonly IMapper _mapper;
        
        public IngredientsController(IIngredientsRepository ingredientsRepository, IMapper mapper)
        {
              _ingredientsService = new IngredientsService(ingredientsRepository, mapper);
              _mapper = mapper;
        }
        
        // GET: api/<api>
        [HttpGet]
        public async Task<IEnumerable<IngredientDTO>> Get()
        {
            var  ingredients = await _ingredientsService.GetIngredients();
            return  _mapper.Map<IEnumerable<IngredientDTO>>(ingredients) ;
        }

        // GET api/<api>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {   
            var ingredient = await _ingredientsService.GetIngredient(id);
            return ingredient == null ? NotFound() : Ok(_mapper.Map<IngredientDTO>(ingredient));
        }

        // POST api/<api>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient =  _ingredientsService.CreateIngredient(ingredientDTO);
            return ingredient == null ? Problem() : NoContent();
        }

        // PUT api/<api>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient = await _ingredientsService.UpdateIngredientById(id, ingredientDTO);
            
            return ingredient == null ? NotFound() : NoContent();
        }

        // DELETE api/<api>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var status = await _ingredientsService.DeleteIngredientById(id);
            return status == false ? NotFound() : NoContent();
        }
    }
}
