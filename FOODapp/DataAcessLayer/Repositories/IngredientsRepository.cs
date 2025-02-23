using DataAcessLayer.Data;
using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Repositories;

public class IngredientsRepository
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
    
}