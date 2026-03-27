using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IMealPlanRepository
{
    Task<List<MealPlan>> GetMealPlan();
    Task<MealPlan> GetMealPlan(int id);
    Task<MealPlan> GetMealPlanByDate(DateOnly WeekYear);
    Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate);
    Task<bool> MakeMealPlan(MealPlan madplan);
    Task<bool> DeleteMealPlan(MealPlan madplan);
    Task<bool> UpdateMealPlan(MealPlan madplan);

}