using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IMealPlanRepository
{
    Task<List<MealPlan>> GetMealPlan();
    Task<MealPlan?> GetMealPlan(int id);
    Task<MealPlan?> GetMealPlanByDate(DateOnly date);
    Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate);
    Task<int> MakeMealPlan(MealPlan mealPlan);
    Task<int?> DeleteMealPlan(MealPlan mealPlan);
    Task<MealPlan?> UpdateMealPlan(MealPlan mealPlan);

}