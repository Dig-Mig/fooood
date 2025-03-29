using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IIngredientsRepository
{
    Task<List<Ingredient>> GetAllIngredients();
    Task<Ingredient?> GetIngredientById(int id);
    Task<Ingredient> PostIngredient(Ingredient ingredient);
    Task<Ingredient?> UpdateIngredient(Ingredient ingredient);
    Task<int?> DeleteIngredient(Ingredient ingredient);
}