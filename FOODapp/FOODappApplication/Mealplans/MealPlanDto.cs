using FOODappApplication.Recipes;

namespace FOODappApplication.MealPlans;

public class MealPlanDto
{
    public DateOnly Date { get; set; }
    public RecipeDTO Recipe { get; set; }
}