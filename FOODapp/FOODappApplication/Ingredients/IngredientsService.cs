using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Ingredients;

public class IngredientsService: IIngredientsService
{
    private IIngredientsRepository _repository;
    private IMapper _mapper;
    public IngredientsService(IIngredientsRepository repository , IMapper mapper)
    {
           _repository = repository;
           _mapper = mapper;
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
        var ingredient = _mapper.Map<Ingredient>(ingredientDTO);
        return await _repository.PostIngredient(ingredient);
    }


    public async Task<bool?> DeleteIngredientById(int id)
    {
        var ingredient = await _repository.GetIngredientById(id);
        if (ingredient == null) return false;
        else
        {
            await _repository.DeleteIngredient(ingredient);
            return true;
        }
        
    }
    
    public async Task<Ingredient?> UpdateIngredientById(int id, IngredientDTO ingredientUpdates)
    {
        var ingredient = await _repository.GetIngredientById(id);
        if (ingredient == null) return null;

        if (ingredientUpdates.Name is not null) ingredient.Name = ingredientUpdates.Name;
        return await _repository.UpdateIngredient(ingredient);
    }
    
    

}