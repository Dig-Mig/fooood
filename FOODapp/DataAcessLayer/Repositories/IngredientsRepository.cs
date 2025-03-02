using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class IngredientsRepository: IIngredientsRepository
{
    private readonly FOODContext _context;

    public IngredientsRepository(FOODContext context)
    {
        _context = context;
    }

    public async Task<Ingredient> PostIngredient(Ingredient ingredient)
    {
        _context.Ingredients.Add(ingredient);
        await _context.SaveChangesAsync();
        return ingredient;
    }
    
    public async Task<List<Ingredient>> GetAllIngredients( )
    {
        return await _context.Ingredients.ToListAsync();
    }

    public async Task<Ingredient?> GetIngredientById(int id)
    {
        return await _context.Ingredients.FindAsync(id);
    }

    public async Task<int?> DeleteIngredient(Ingredient ingredient)
    {
        _context.Ingredients.Remove(ingredient);
        return await _context.SaveChangesAsync();
    }
}