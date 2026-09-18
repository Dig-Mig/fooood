using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Ingredients;

public class IngredientsService(IIngredientsRepository repository, IMapper mapper) : IIngredientsService
{
    public async Task<List<Ingredient>> GetIngredients()
    {
        return await repository.GetAllIngredients();
    }
    
    public async Task<Ingredient> GetIngredient(int id)
    {
        var ingredient = await repository.GetIngredientById(id);
        return  ingredient;
    }

    public async Task<Ingredient> CreateIngredient(IngredientUpdateDTO ingredientUpdateDTO)
    {   
        var ingredient = mapper.Map<Ingredient>(ingredientUpdateDTO);
        return await repository.PostIngredient(ingredient);
    }


    public async Task<bool?> DeleteIngredientById(int id)
    {
        var ingredient = await repository.GetIngredientById(id);
        if (ingredient == null) return false;
        else
        {
            await repository.DeleteIngredient(ingredient);
            return true;
        }
        
    }
    
    public async Task<Ingredient?> UpdateIngredientById(int id, IngredientUpdateDTO ingredientUpdates)
    {
        var ingredient = await repository.GetIngredientById(id);
        if (ingredient == null) return null;

        if (ingredientUpdates.Name is not null) ingredient.Name = ingredientUpdates.Name;
        return await repository.UpdateIngredient(ingredient);
    }
    
}