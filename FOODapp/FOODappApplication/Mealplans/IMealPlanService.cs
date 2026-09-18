namespace FOODappApplication.Mealplans;

public interface IMealPlanService
{
    Task<List<MealPlanDto>> getAllMealPlans();
}