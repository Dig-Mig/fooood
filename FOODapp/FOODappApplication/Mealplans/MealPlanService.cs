using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.MealPlans;

public class MealPlanService(IMealPlanRepository mealPlanRepository, IRecipeRepository recipeRepository, IMapper mapper) : IMealPlanService
{
    public async Task<List<MealPlan>> GetAllMealPlans()
    {
        var mealPlans = await mealPlanRepository.GetMealPlan();
        return mealPlans;
    }

    public async Task<MealPlan>? GetMealPlanById(int id)
    {
        var mealPlan = await mealPlanRepository.GetMealPlan(id);
        return mealPlan;
    }

    public async Task<MealPlan>? GetMealPlanByDate(DateOnly date)
    {
        var mealPlan = await mealPlanRepository.GetMealPlanByDate(date);
        return mealPlan;
    }

    public async Task<List<MealPlan>>? GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate)
    {
        var mealPlans = await mealPlanRepository.GetMealPlanByDateRange(startDate, endDate);
        return mealPlans;
    }

    public async Task<int?> MakeMealPlan(MealPlanUpdateDto mealPlanUpdateDto)
    {
        var recipe = await recipeRepository.GetRecipeById(mealPlanUpdateDto.RecipeId);
        if (recipe == null) return null;

        var mealPlan = new MealPlan
        {
            Date = mealPlanUpdateDto.Date,
            Recipe = recipe 
        };
        
        return await mealPlanRepository.MakeMealPlan(mealPlan);
    }

    public async Task<int?> DeleteMealPlan(int id)
    {
        var mealPlan = await mealPlanRepository.GetMealPlan(id);
        if (mealPlan == null) return null;
        else
        {
            return await mealPlanRepository.DeleteMealPlan(mealPlan); 
        }
    }

    public async Task<MealPlan?> UpdateMealPlanById(int id, MealPlanUpdateDto mealPlanUpdateDto)
    {
        var mealplan = await mealPlanRepository.GetMealPlan(id);
        if (mealplan == null) return null;
        var newMealPlan = mapper.Map(mealPlanUpdateDto, mealplan);
        var updatedMealPlan = await mealPlanRepository.UpdateMealPlan(newMealPlan);
        return updatedMealPlan;
    }
}