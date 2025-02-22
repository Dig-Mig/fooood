namespace FOODappApplication;

public class IngredientsService: IIngredientsService
{
    public IngredientsService()
    {
            
    }
    public List<string> GetIngredients()
    {
        var ingredients = new List<string>
        {
            "Apple",
            "Bananas",
            "Pineapple",
            "Orange",
            
        };
        return ingredients;
    }
    
    public string? GetIngredient(int id)
    {
        var ingredients = new List<string>
        {
            "Apple",
            "Bananas",
            "Pineapple",
            "Orange",
            
        };
    
        return ingredients[id] ?? null;
    }


}