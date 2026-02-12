using DataAcessLayer.Models;

namespace FOODappApplication.Recipes;

public interface IRecipeService
{
    Task<List<Recipe>> GetRecipes();
    Task<Recipe>? GetRecipe(int id);
    Task<Recipe> CreateRecipe(Recipe recipe);
    Task<Recipe?> UpdateRecipeById(int id, RecipeUpdateDTO recipeUpdates);
    Task<int?> DeleteRecipeById(int id);
}