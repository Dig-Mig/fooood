using System.ComponentModel.DataAnnotations;

namespace DataAcessLayer.Models;

public class MealPlan
{
    public int Id { get; set; }

    [Required] 
    public DateOnly Date { get; set; }
    
    public virtual Recipe recipe { get; set; }

}