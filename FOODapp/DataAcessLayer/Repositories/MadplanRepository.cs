using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class MadplanRepository : IMealPlanRepository
{
    
    private readonly FOODContext _context;

    public MadplanRepository(FOODContext context)
    {
        _context = context;
    }

    public async Task<List<MealPlan>> GetMealPlan()
    {
        return await _context.MealPlans.ToListAsync();
    }

    public async Task<MealPlan> GetMealPlan(int id)
    {
        return await _context.MealPlans.FirstOrDefaultAsync(mealplan => mealplan.Id == id);
    }

    public async Task<MealPlan> GetMealPlanByDate(DateOnly WeekYear)
    {
        return await _context.MealPlans.FirstOrDefaultAsync(mealplan => mealplan.Date == WeekYear);
    }

    public async Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate)
    {
        return await _context.MealPlans.Where(mealplan => mealplan.Date >= startDate && mealplan.Date <= endDate ).ToListAsync(); 
    }

    public async Task<int> MakeMealPlan(MealPlan madplan)
    {
        var result =  await _context.MealPlans.AddAsync(madplan);
        await _context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<bool> DeleteMealPlan(MealPlan madplan)
    {
        _context.MealPlans.Remove(madplan);

        return await _context.SaveChangesAsync() != 0 ? true : false;
    }

    public async Task<bool> UpdateMealPlan(MealPlan madplan)
    {
        _context.MealPlans.Update(madplan);

        return await _context.SaveChangesAsync() != 0 ? true : false;
    }
}