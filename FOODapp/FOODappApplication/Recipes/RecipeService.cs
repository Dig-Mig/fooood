using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Recipes;

public class RecipeService : IRecipeService
{
    
    private IRecipeRepository _repository;
    
    public RecipeService(IRecipeRepository repository)
    {
        _repository = repository; 
    }
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
        var recipe = MapFromDTO(recipeDTO);
        return await _repository.PostRecipe(recipe);
    }

    public async Task<Recipe?> UpdateRecipeById(int id, RecipeDTO recipeUpdates)
    {
        throw new NotImplementedException();
    }

    public async Task<int?> DeleteRecipeById(int id)
    {
        throw new NotImplementedException();
    }
    
    private Recipe MapFromDTO(RecipeDTO recipeDto)
    {
        var recipe = new Recipe()
        {
            Name = recipeDto.Name,
        };
        return recipe;
    }
}