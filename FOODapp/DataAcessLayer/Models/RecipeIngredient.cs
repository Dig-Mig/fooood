using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.Models;

public class RecipeIngredient
{
    public int Id { get; set; }

    [Required]
    public int RecipeId { get; set; }
    
    [Required] 
    public int IngredientId { get; set; }
    
    [Required]
    public virtual Recipe Recipe { get; set; }
    
    [Required]
    public virtual Ingredient Ingredient { get; set; }
    
    public int Amount { get; set; }
}