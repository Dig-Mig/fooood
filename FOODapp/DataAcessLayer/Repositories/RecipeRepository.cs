using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class RecipeRepository(FOODContext context) : IRecipeRepository
{
    public async Task<List<Recipe>> GetAllRecipes()
    {
        return await context.Recipes.ToListAsync();
    }

    public async Task<Recipe?> GetRecipeById(int id)
    {
        return await context.Recipes.FindAsync(id);
    }

    public async Task<Recipe> PostRecipe(Recipe recipe)
    {
        await context.Recipes.AddAsync(recipe);
        await context.SaveChangesAsync();
        return recipe;
    }

    public async Task<Recipe?> UpdateRecipe(Recipe recipe)
    {
        context.Recipes.Update(recipe);
        await context.SaveChangesAsync();
        var updatedRecipe = await context.Recipes.FindAsync(recipe.Id);
        return updatedRecipe;
    }

    public async Task<int?> DeleteRecipe(Recipe recipe)
    {
        context.Remove(recipe);
        return await context.SaveChangesAsync();
    }
    
    public async Task<List<RecipeIngredient>> GetRecipieIngcredients(int id)
    {
        List<RecipeIngredient> recipeIngredients = await context.RecipeIngredients
            .Where(recipeIngredient => recipeIngredient.Id == id).ToListAsync();
        return recipeIngredients;
    }
}