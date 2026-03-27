using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IMadplanRepository
{
    Task<List<MealPlan>> GetMadlans();
    Task<MealPlan> GetMadPlan(int id);
    Task<MealPlan> GetMadPlanByDate(DateOnly WeekYear);
    Task<List<MealPlan>> GetMadByDateRange(DateOnly startDate, DateOnly endDate);
    Task<bool> MakeMadPlan(MealPlan mealPlan);
    Task<bool> DeleteMadPlan(MealPlan mealPlan);
    Task<bool> UpdateMadPlan(MealPlan mealPlan);

}