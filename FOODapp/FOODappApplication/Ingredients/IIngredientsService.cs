using DataAcessLayer.Models;

namespace FOODappApplication;

public interface IIngredientsService
{
    Task<List<Ingredient>> GetIngredients();
    string? GetIngredient(int id);
    Task<Ingredient> CreateIngredient(IngredioentDTO ingredientDTO);
}