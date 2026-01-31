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
        var recipes = await _repository.GetAllRecipes();
        return recipes;
    }

    public async Task<Recipe>? GetRecipe(int id)
    {
        var recipe = await _repository.GetRecipeById(id);
        return recipe;
    }

    public async Task<Recipe> CreateRecipe(RecipeDTO recipeDTO)
    { 
        var recipe = MapFromDTO(recipeDTO);
        return await _repository.PostRecipe(recipe);
    }

    public async Task<Recipe?> UpdateRecipeById(int id, RecipeDTO recipeUpdates)
    {
        var recipe = await _repository.GetRecipeById(id);
        if (recipe == null) return null;

        else recipe = MapFromDTO(recipeUpdates);
        recipe = await _repository.UpdateRecipe(recipe);
        return await _repository.UpdateRecipe(recipe);
    }

    public async Task<int?> DeleteRecipeById(int id)
    {
        var recipe = await _repository.GetRecipeById(id);
        if (recipe == null) return null;
        else { return await _repository.DeleteRecipe(recipe); }
    }

    private static Recipe MapFromDTO(RecipeDTO recipeDTO)
    {
        var recipe = new Recipe()
        {
            Name = recipeDTO.Name,
            Link = recipeDTO.Link,
            Description = recipeDTO.Description,
            Servings =  recipeDTO.Servings,
            KitchenType =  recipeDTO.KitchenType
        };
        return recipe;
    }
}