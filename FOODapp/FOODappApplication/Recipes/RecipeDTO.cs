using DataAcessLayer.Enums;
using AutoMapper;
using DataAcessLayer.Models;

namespace FOODappApplication.Recipes;

public class RecipeDTO
{
    public string Name { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public int Servings { get; set; }
    public KitchenType KitchenType { get; set; }
}

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RecipeDTO, Recipe>();
    }
}