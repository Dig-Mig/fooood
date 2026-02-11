using AutoMapper;
using DataAcessLayer.Enums;
using DataAcessLayer.Models;
using FOODappApplication.Ingredients;

namespace FOODappApplication.Recipes;
public class RecipeUpdateDTO
{
    public string? Name { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public int? Servings { get; set; }
    public KitchenType? KitchenType { get; set; }
    
    public List<RecipeIngredientDTO>? RecipeIngredients { get; set; }
}

public class RecipeIngredientUpdateDTO
{
    public IngredientDTO Ingredient { get; set; }
    public int Amount { get; set; }
}

