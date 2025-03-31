using System.ComponentModel.DataAnnotations;
using DataAcessLayer.Enums;
namespace DataAcessLayer.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Link { get; set; }
    public string? Description { get; set; }
    public int Servings { get; set; }
    public KitchenType KitchenType { get; set; }
}

