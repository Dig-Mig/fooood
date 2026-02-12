using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Recipes;

public class RecipeService : IRecipeService
{
    private IRecipeRepository _repository;
    private IMapper _mapper;
    private IRecipeService _recipeServiceImplementation;

    public RecipeService(IRecipeRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;

    }
    public async Task<List<Recipe>> GetRecipes()
    {
        var recipes = await _repository.GetAllRecipes();
        return recipes;
    }

    public async Task<Recipe>? GetRecipe(int id)
    {
        var recipe = await _repository.GetRecipeById(id);
        return recipe;
    }

    public async Task<Recipe> CreateRecipe(Recipe recipe)
    {
        return await _repository.PostRecipe(recipe);
    }
    

    public async Task<Recipe?> UpdateRecipeById(int id, RecipeUpdateDTO recipeUpdates)
    {
        var recipe = await _repository.GetRecipeById(id);
        if (recipe == null) return null;
        var newRecipe = _mapper.Map<RecipeUpdateDTO,Recipe>(recipeUpdates, recipe);
        var Updatedrecipe = await _repository.UpdateRecipe(newRecipe);
        return  Updatedrecipe;
    }

    public async Task<int?> DeleteRecipeById(int id)
    {
        var recipe = await _repository.GetRecipeById(id);
        if (recipe == null) return null;
        else { return await _repository.DeleteRecipe(recipe); }
    }

    

 }
