using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public class RecipeRepository : IRecipeRepository
{
    public Task<List<Recipe>> GetAllRecipes()
    {
        throw new NotImplementedException();
    }

    public Task<Recipe?> GetRecipeById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Recipe> PostRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task<Recipe?> UpdateRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
    }

    public Task<int?> DeleteRecipe(Recipe recipe)
    {
        throw new NotImplementedException();
    }
}