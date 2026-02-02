using AutoMapper;
using DataAcessLayer.Enums;
using DataAcessLayer.Models;
using FOODappApplication.Ingredients;

namespace FOODappApplication.Recipes;
public class RecipeDTO
{
    public string Name { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public int Servings { get; set; }
    public KitchenType KitchenType { get; set; }
    
    public List<RecipeIngredientDTO> Ingredient { get; set; }
}

public class RecipeIngredientDTO
{
    public IngredientDTO Ingredient { get; set; }
    public int Amount { get; set; }
}

