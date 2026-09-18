using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class MealPlanRepository(FOODContext context) : IMealPlanRepository
{
    public async Task<List<MealPlan>> GetMealPlan()
    {
        return await context.MealPlans.ToListAsync();
    }

    public async Task<MealPlan?> GetMealPlan(int id)
    {
        return await context.MealPlans.FirstOrDefaultAsync(mealPlan => mealPlan.Id == id);
    }

    public async Task<MealPlan?> GetMealPlanByDate(DateOnly date)
    {
        return await context.MealPlans.FirstOrDefaultAsync(mealPlan => mealPlan.Date == date);
    }

    public async Task<List<MealPlan>> GetMealPlanByDateRange(DateOnly startDate, DateOnly endDate)
    {
        return await context.MealPlans.Where(mealPlan => mealPlan.Date >= startDate && mealPlan.Date <= endDate ).ToListAsync(); 
    }

    public async Task<int> MakeMealPlan(MealPlan mealPlan)
    {
        var result =  await context.MealPlans.AddAsync(mealPlan);
        await context.SaveChangesAsync();
        return result.Entity.Id;
    }

    public async Task<int?> DeleteMealPlan(MealPlan mealPlan)
    {
        context.Remove(mealPlan);
        return await context.SaveChangesAsync();
    }

    public async Task<MealPlan?> UpdateMealPlan(MealPlan mealPlan)
    {
        context.MealPlans.Update(mealPlan);
        await context.SaveChangesAsync();
        var updatedMealPlan =  await context.MealPlans.FindAsync(mealPlan.Id);
        return updatedMealPlan;
    }
}