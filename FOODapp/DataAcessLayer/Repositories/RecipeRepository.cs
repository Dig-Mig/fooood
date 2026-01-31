using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class RecipeRepository : IRecipeRepository
{
    private readonly FOODContext _context;

    public RecipeRepository(FOODContext context)
    {
        _context = context;
    }
    public async Task<List<Recipe>> GetAllRecipes()
    {
        return await _context.Recipes.ToListAsync();
    }

    public async Task<Recipe?> GetRecipeById(int id)
    {
        return await _context.Recipes.FindAsync(id);
    }

    public async Task<Recipe> PostRecipe(Recipe recipe)
    {
        await _context.Recipes.AddAsync(recipe);
        await _context.SaveChangesAsync();
        return recipe;
    }

    public async Task<Recipe?> UpdateRecipe(Recipe recipe)
    {
        _context.Recipes.Update(recipe);
        await _context.SaveChangesAsync();
        return recipe;
    }

    public async Task<int?> DeleteRecipe(Recipe recipe)
    {
        _context.Remove(recipe);
        return await _context.SaveChangesAsync();
    }
}