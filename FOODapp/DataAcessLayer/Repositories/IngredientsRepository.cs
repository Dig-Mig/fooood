using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class IngredientsRepository(FOODContext context) : IIngredientsRepository
{
    public async Task<List<Ingredient>> GetAllIngredients( )
    {
        return await context.Ingredients.ToListAsync();
    }

    public async Task<Ingredient?> GetIngredientById(int id)
    {
        return await context.Ingredients.FindAsync(id);
    }
    
    public async Task<Ingredient> PostIngredient(Ingredient ingredient)
    {
        context.Ingredients.Add(ingredient);
        await context.SaveChangesAsync();
        return ingredient;
    }
    
    public async Task<Ingredient?> UpdateIngredient(Ingredient ingredient)
    {   
        context.Ingredients.Update(ingredient);
        await context.SaveChangesAsync();
        return ingredient;
    }

    public async Task<int?> DeleteIngredient(Ingredient ingredient)
    {
        context.Ingredients.Remove(ingredient);
        return await context.SaveChangesAsync();
    }
}