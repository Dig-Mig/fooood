using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Ingredients;

public class IngredientsService: IIngredientsService
{
    private IIngredientsRepository _repository;
    public IngredientsService(IIngredientsRepository repository)
    {
           _repository = repository; 
    }
    public async Task<List<Ingredient>> GetIngredients()
    {
        return await _repository.GetAllIngredients();
    }
    
    public async Task<Ingredient> GetIngredient(int id)
    {
        var ingredient = await _repository.GetIngredientById(id);
        return  ingredient;
    }

    public async Task<Ingredient> CreateIngredient(IngredientDTO ingredientDTO)
    {   
        var ingredient = MapFromDTO(ingredientDTO);
        return await _repository.PostIngredient(ingredient);
    }


    public async Task<int?> DeleteIngredientById(int id)
    {
        var ingredient = await _repository.GetIngredientById(id);
        if (ingredient == null) return null;
        else { return await _repository.DeleteIngredient(ingredient); }
        
    }
    
    public async Task<Ingredient?> UpdateIngredientById(int id, IngredientDTO ingredientUpdates)
    {
        var ingredient = await _repository.GetIngredientById(id);
        if (ingredient == null) return null;

        if (ingredientUpdates.Name is not null) ingredient.Name = ingredientUpdates.Name;
        if (ingredientUpdates.Stock is not null) ingredient.Stock = ingredientUpdates.Stock;
        if (ingredientUpdates.Quantity is not null) ingredient.Quantity = ingredientUpdates.Quantity;
        if (ingredientUpdates.QuantityUnit is not null) ingredient.QuantityUnit = ingredientUpdates.QuantityUnit;

        return await _repository.UpdateIngredient(ingredient);
    }
    
    
    private Ingredient MapFromDTO(IngredientDTO ingredientDTO)
    {
        var ingredient = new Ingredient()
        {
            Name = ingredientDTO.Name,
            Stock = ingredientDTO.Stock,
            Quantity = ingredientDTO.Quantity,
            QuantityUnit = ingredientDTO.QuantityUnit
        };
        return ingredient;
    }
    

}