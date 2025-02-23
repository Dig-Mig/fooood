using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication;

public class IngredientsService: IIngredientsService
{
    private IngredientsRepository _repository;
    public IngredientsService(IngredientsRepository repository)
    {
           _repository = repository; 
    }
    public async Task<List<Ingredient>> GetIngredients()
    {
        return await _repository.GetAllIngredients();
    }
    
    public string? GetIngredient(int id)
    {
        var ingredients = new List<string>
        {
            "Apple",
            "Bananas",
            "Pineapple",
            "Orange",
            
        };
    
        return ingredients[id] ?? null;
    }

    public async Task<Ingredient> CreateIngredient(IngredioentDTO ingredientDTO)
    {   
        var ingredient =MapFromDTO(ingredientDTO);
        return await _repository.PostIngredient(ingredient);
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