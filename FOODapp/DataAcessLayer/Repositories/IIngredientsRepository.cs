using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IIngredientsRepository
{
    Task<Ingredient> PostIngredient(Ingredient ingredient);
    Task<List<Ingredient>> GetAllIngredients();
    Task<Ingredient>? GetIngredientById(int id);
}