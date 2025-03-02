using DataAcessLayer.Models;

namespace FOODappApplication;

public interface IIngredientsService
{
    Task<List<Ingredient>> GetIngredients();
    Task<Ingredient>? GetIngredient(int id);
    Task<Ingredient> CreateIngredient(IngredioentDTO ingredientDTO);
    
    Task<int?> DeleteIngredientById(int id);
    Task<Ingredient?> UpdateIngredientById(int id, IngredioentDTO ingredientUpdates);

}