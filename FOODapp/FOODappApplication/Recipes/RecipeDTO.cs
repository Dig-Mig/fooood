using DataAcessLayer.Enums;

namespace FOODappApplication.Recipes;

public class RecipeDTO
{
    public string Name { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public int Servings { get; set; }
    public KitchenType KitchenType { get; set; }
    
}