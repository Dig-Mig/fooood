using DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAcessLayer.Data;

public class FOODContext : DbContext
{
    public FOODContext(DbContextOptions<FOODContext> options) : base(options) { }
    
    public DbSet<Ingredient> Ingredients { get; set; } = null!;
    public DbSet<Recipe> Recipes { get; set; } = null!;
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseLazyLoadingProxies().UseSqlite("Data Source=FOOD.db");
    }
}