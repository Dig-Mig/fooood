using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication;

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

    public async Task<Ingredient> CreateIngredient(IngredioentDTO ingredientDTO)
    {   
        var ingredient =MapFromDTO(ingredientDTO);
        return await _repository.PostIngredient(ingredient);
    }


    public async Task<int?> DeleteIngredientById(int id)
    {
        var ingredient = await _repository.GetIngredientById(id);
        if (ingredient == null) return null;
        else { return await _repository.DeleteIngredient(ingredient); }
        
    }
    
    private Ingredient MapFromDTO(IngredioentDTO ingredientDTO)
    {
        var ingredient = new Ingredient()
        {
            Name = ingredientDTO.Name
        };
        return ingredient;
    }
    

}