using DataAcessLayer.Models;

namespace FOODappApplication.Ingredients;

public interface IIngredientsService
{
    Task<List<Ingredient>> GetIngredients();
    Task<Ingredient>? GetIngredient(int id);
    Task<Ingredient> CreateIngredient(IngredientUpdateDTO ingredientUpdateDTO);
    Task<Ingredient?> UpdateIngredientById(int id, IngredientUpdateDTO ingredientUpdates);
    Task<bool?> DeleteIngredientById(int id);


}