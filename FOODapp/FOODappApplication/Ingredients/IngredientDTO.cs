namespace FOODappApplication.Ingredients;

public class IngredientDTO
{
    public string Name { get; set; } = String.Empty;
    public bool? Stock  { get; set; }
    public int? Quantity { get; set; }
    public string? QuantityUnit { get; set; }
}