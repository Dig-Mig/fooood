using FOODappApplication.Ingredients;
using FOODappApplication.Recipes;

namespace Frontend.ApiClients;

public class FoodClient
{
    HttpClient httpClient;
    public FoodClient()
    {
          httpClient = new HttpClient(){BaseAddress = new Uri("http://localhost:5295")};  
    }

    public async Task<List<IngredientDTO>> GetIngredients()
    {
      var respone = await httpClient.GetAsync("api/Ingredients");
      return await respone.Content.ReadFromJsonAsync<List<IngredientDTO>>();
    }

    public async Task<RecipeDTO> GetRecipe(int id)
    {
        var responce = await httpClient.GetAsync($"api/Recipes/{id}");
        return await responce.Content.ReadFromJsonAsync<RecipeDTO>();
    }
}