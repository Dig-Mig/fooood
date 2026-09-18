using DataAcessLayer.Models;

namespace FOODappApplication.MealPlans;

public interface IMealPlanService
{
    Task<List<MealPlan>> GetAllMealPlans();
    Task<MealPlan>? GetMealPlanById(int id);
    Task<MealPlan>? GetMealPlanByDate(DateOnly date);
    Task<List<MealPlan>>? GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate);
    Task<int?> MakeMealPlan(MealPlanUpdateDto mealPlanUpdateDto);
    Task<int?> DeleteMealPlan(int id);
    Task<MealPlan?> UpdateMealPlanById(int id, MealPlanUpdateDto mealPlanUpdateDto);
}