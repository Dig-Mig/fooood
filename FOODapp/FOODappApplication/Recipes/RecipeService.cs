using DataAcessLayer.Models;

namespace FOODappApplication.Recipes;

public class RecipeService : IRecipeService
{
    public async Task<List<Recipe>> GetRecipes()
    {
        throw new NotImplementedException();
    }

    public async Task<Recipe>? GetRecipe(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Recipe> CreateRecipe(RecipeDTO recipeDTO)
    {
        throw new NotImplementedException();
    }

    public async Task<Recipe?> UpdateRecipeById(int id, RecipeDTO recipeUpdates)
    {
        throw new NotImplementedException();
    }

    public async Task<int?> DeleteRecipeById(int id)
    {
        throw new NotImplementedException();
    }
}