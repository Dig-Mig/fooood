using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IMealPlanRepository
{
    Task<List<MealPlan>> GetMealPlan();
    Task<MealPlan> GetMealPlan(int id);
    Task<MealPlan> GetMealPlanByDate(DateOnly WeekYear);
    Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate);
    Task<int> MakeMealPlan(MealPlan madplan);
    Task<bool> DeleteMealPlan(MealPlan madplan);
    Task<bool> UpdateMealPlan(MealPlan madplan);

}