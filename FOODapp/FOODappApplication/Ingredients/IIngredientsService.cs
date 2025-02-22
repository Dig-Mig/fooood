namespace FOODappApplication;

public interface IIngredientsService
{
    List<string> GetIngredients();
    string? GetIngredient(int id);
}