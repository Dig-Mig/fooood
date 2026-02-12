using DataAcessLayer.Models;

namespace FOODappApplication.Ingredients;

public interface IIngredientsService
{
    Task<List<Ingredient>> GetIngredients();
    Task<Ingredient>? GetIngredient(int id);
    Task<Ingredient> CreateIngredient(IngredientDTO ingredientDTO);
    Task<Ingredient?> UpdateIngredientById(int id, IngredientDTO ingredientUpdates);
    Task<bool?> DeleteIngredientById(int id);


}