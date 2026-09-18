using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Recipes;

public class RecipeService(IRecipeRepository repository, IMapper mapper) : IRecipeService
{
    public async Task<List<Recipe>> GetRecipes()
    {
        var recipes = await repository.GetAllRecipes();
        return recipes;
    }

    public async Task<Recipe>? GetRecipe(int id)
    {
        var recipe = await repository.GetRecipeById(id);
        return recipe;
    }

    public async Task<Recipe> CreateRecipe(Recipe recipe)
    {
        return await repository.PostRecipe(recipe);
    }
    

    public async Task<Recipe?> UpdateRecipeById(int id, RecipeUpdateDTO recipeUpdates)
    {
        var recipe = await repository.GetRecipeById(id);
        if (recipe == null) return null;
        var newRecipe = mapper.Map<RecipeUpdateDTO,Recipe>(recipeUpdates, recipe);
        var  updatedRecipe = await repository.UpdateRecipe(newRecipe);
        return   updatedRecipe;
    }

    public async Task<int?> DeleteRecipeById(int id)
    {
        var recipe = await repository.GetRecipeById(id);
        if (recipe == null) return null;
        else { return await repository.DeleteRecipe(recipe); }
    }
}
