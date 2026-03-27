using DataAcessLayer.Data;
using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public class MadplanRepository : IMealPlanRepository
{
    
    private readonly FOODContext _context;

    public MadplanRepository(FOODContext context)
    {
        _context = context;
    }

    public Task<List<MealPlan>> GetMealPlan()
    {
        throw new NotImplementedException();
    }

    public Task<MealPlan> GetMealPlan(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MealPlan> GetMealPlanByDate(DateOnly WeekYear)
    {
        throw new NotImplementedException();
    }

    public Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MakeMealPlan(MealPlan madplan)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMealPlan(MealPlan madplan)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateMealPlan(MealPlan madplan)
    {
        throw new NotImplementedException();
    }
}