using AutoMapper;
using DataAcessLayer.Models;
using FOODappApplication.Recipes;
using FOODappApplication.Ingredients;
using FOODappApplication.MealPlans;

namespace FOODappApplication.Profiles;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        CreateMap<Recipe, RecipeDTO>();
        CreateMap<RecipeIngredient, RecipeIngredientDTO>();
        CreateMap<Ingredient, IngredientDTO>();
        CreateMap<RecipeDTO, Recipe>();
        CreateMap<RecipeIngredientDTO, RecipeIngredient>();
        CreateMap<IngredientDTO, Ingredient>();
        CreateMap<IngredientUpdateDTO, Ingredient>();
        CreateMap<RecipeUpdateDTO, Recipe>();
        CreateMap<MealPlanDto, MealPlan>();
        CreateMap<MealPlan, MealPlanDto>();
        CreateMap<RecipeIngredientUpdateDTO, RecipeIngredient>();
        CreateMap<RecipeIngredient, RecipeIngredientUpdateDTO>();
        CreateMap<MealPlanUpdateDto, MealPlan>();
        CreateMap<MealPlan, MealPlanUpdateDto>();
    }
}