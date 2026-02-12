using DataAcessLayer.Models;
 

namespace DataAcessLayer.Repositories;

public interface IRecipeRepository
{
    Task<List<Recipe>> GetAllRecipes();
    Task<Recipe?> GetRecipeById(int id);
    Task<Recipe> PostRecipe(Recipe recipe);
    Task<Recipe?> UpdateRecipe(Recipe recipe);
    Task<int?> DeleteRecipe(Recipe recipe);
    Task<List<RecipeIngredient>> GetRecipieIngcredients(int id);
}