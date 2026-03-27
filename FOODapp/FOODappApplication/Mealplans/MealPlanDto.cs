using FOODappApplication.Recipes;

namespace FOODappApplication.Mealplans;

public class MealPlanDto
{
    
    public DateOnly Date { get; set; }
    
    public virtual RecipeDTO recipe { get; set; }

}