using DataAcessLayer.Data;
using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public class MadplanRepository : IMadplanRepository
{
    
    private readonly FOODContext _context;

    public MadplanRepository(FOODContext contrex)
    {
        _context = contrex;
    }
    public Task<List<MealPlan>> GetMadlans()
    {
        throw new NotImplementedException();
        
    }

    public Task<MealPlan> GetMadPlan(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MealPlan> GetMadPlanByDate(DateOnly WeekYear)
    {
        throw new NotImplementedException();
    }

    public Task<List<MealPlan>> GetMadByDateRange(DateOnly startDate, DateOnly endDate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> MakeMadPlan(MealPlan mealPlan)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMadPlan(MealPlan mealPlan)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateMadPlan(MealPlan mealPlan)
    {
        throw new NotImplementedException();
    }
}