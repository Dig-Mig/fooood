using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.Models;

public class RecipeIngredient
{
    public int Id { get; set; }
    
    [Required]
    public Recipe Recipe { get; set; }
    
    [Required]
    public Ingredient Ingredient { get; set; }
    
    public int Amount { get; set; }
}