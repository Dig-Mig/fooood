using AutoMapper;
using DataAcessLayer.Repositories;
using FOODappApplication.Ingredients;
using FOODappApplication.Mealplans;
using Microsoft.AspNetCore.Mvc;

namespace FOODappAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MealPlanController : ControllerBase
{
    private IMealPlanService _mealPlanService;
    

    public MealPlanController(IMealPlanRepository mealPlanRepository  , IMapper mapper)
    {
        _mealPlanService = new MealPlanService(mealPlanRepository,mapper);
    }
    // GET: api/<api>
    [HttpGet]
    public async Task<List<MealPlanDto>> Get()
    {
        var result = await _mealPlanService.getAllMealPlans();
        return result;
    }
}