using AutoMapper;
using DataAcessLayer.Data;
using DataAcessLayer.Models;
using FOODappApplication.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NuGet.Common;

namespace IntegrationTests;

public class TestContextFixture : IDisposable
{
    public FOODContext FoodContext { get; private set; }
    public IMapper Mapper { get; private set; }
    
    
    public TestContextFixture()
    {
        //builder.Services.AddAutoMapper(cfg => cfg.LicenseKey = builder.Configuration.GetValue<string>("AutomapperLicense"), typeof(AutomapperProfiles).Assembly);
        // builder.Services.AddDbContext<FOODContext>(options => options.UseLazyLoadingProxies().UseSqlite("Data Source=FOOD.db"));
        //Create universal mapper
        var loggerFactory = new LoggerFactory();
        var mapperConfig = new MapperConfiguration(
            cfg => cfg.AddProfile(new AutomapperProfiles()),
            loggerFactory);
        Mapper = new Mapper(mapperConfig);
        
        //Create options and Context
        DbContextOptions<FOODContext> options = new DbContextOptionsBuilder<FOODContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .EnableSensitiveDataLogging()                
            .Options;
        
        FoodContext = new FOODContext(options);
        
        //Add test data
        FoodContext.Ingredients.AddRange(TestIngredients());
        
        //Save all changes
        FoodContext.SaveChanges();
    }

    private List<Ingredient> TestIngredients()
    {
        return
        [
            new Ingredient() { Id = 1, Name = "Olie" },
            new Ingredient() { Id = 2, Name = "Kærlighed" },
            new Ingredient() { Id = 3, Name = "Gulerødder" }
        ];
    }

    public void Dispose()
    {
        FoodContext.Dispose();
    }
}