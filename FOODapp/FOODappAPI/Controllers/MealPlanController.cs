using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;
using FOODappApplication.MealPlans;
using Microsoft.AspNetCore.Mvc;

namespace FOODappAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MealPlanController(IMealPlanRepository mealPlanRepository, IRecipeRepository recipeRepository, IMapper mapper) : ControllerBase
{
    private IMealPlanService _mealPlanService = new MealPlanService(mealPlanRepository, recipeRepository, mapper);

    // GET: api/<api>
    [HttpGet]
    public async Task<IEnumerable<MealPlanDto>> Get()
    {
        var mealPlans = await _mealPlanService.GetAllMealPlans(); 
        var dto = mapper.Map<IEnumerable<MealPlanDto>>(mealPlans);
        return dto;
    }

    [HttpGet("id/{id}")]
    public async Task<ActionResult> Get(int id)
    {
        var mealPlan = await _mealPlanService.GetMealPlanById(id);
        return mealPlan == null ? NotFound() : Ok(mapper.Map<MealPlanDto>(mealPlan));
    }

    [HttpGet("date/{date}")]
    public async Task<ActionResult> GetByDate(DateOnly date)
    {
        var mealPlan = await _mealPlanService.GetMealPlanByDate(date);
        return mealPlan == null ? NotFound() : Ok(mapper.Map<MealPlanDto>(mealPlan));
    }

    [HttpGet("dateRange")]
    public async Task<IEnumerable<MealPlanDto>> GetByDateRange(DateOnly startDate, DateOnly endDate)
    {
        var mealPlans = await _mealPlanService.GetMealPlanByDateRange(startDate, endDate);
        var dto = mapper.Map<IEnumerable<MealPlanDto>>(mealPlans);
        return dto;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] MealPlanUpdateDto mealPlanUpdateDto)
    {
        var result = _mealPlanService.MakeMealPlan(mealPlanUpdateDto);
        return result == null ? Problem() : Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] MealPlanUpdateDto mealPlanUpdateDto)
    {
        var mealPlan = await _mealPlanService.UpdateMealPlanById(id, mealPlanUpdateDto);
        return mealPlan == null ? NotFound() : Ok(mapper.Map<MealPlanDto>(mealPlan));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var status = await _mealPlanService.DeleteMealPlan(id);
        return status == null ? NotFound() : NoContent();
    }
}