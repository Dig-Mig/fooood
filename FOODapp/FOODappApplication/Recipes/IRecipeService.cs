using DataAcessLayer.Models;

namespace FOODappApplication.Recipes;

public interface IRecipeService
{
    Task<List<Recipe>> GetRecipes();
    Task<Recipe>? GetRecipe(int id);
    Task<Recipe> CreateRecipe(RecipeDTO recipeDTO);
    Task<Recipe?> UpdateRecipeById(int id, RecipeDTO recipeUpdates);
    Task<int?> DeleteRecipeById(int id);
}