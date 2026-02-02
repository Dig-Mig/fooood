using AutoMapper;
using DataAcessLayer.Models;
using FOODappApplication.Recipes;
using FOODappApplication.Ingredients;

namespace FOODappApplication.Profiles;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        CreateMap<Recipe, RecipeDTO>();
        CreateMap<RecipeIngredient, RecipeIngredientDTO>();
        CreateMap<Ingredient, IngredientDTO>();
    }
}