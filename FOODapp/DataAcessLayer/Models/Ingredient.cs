using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.Models;

public class Ingredient
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public bool Stock  { get; set; }
    public int Quantity { get; set; }
    public string QuantityUnit { get; set; }
    
    
}