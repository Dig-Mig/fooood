using System.Net;
using DataAcessLayer.Repositories;
using FluentAssertions;
using FOODappAPI.Controllers;
using FOODappApplication.Ingredients;
using Microsoft.AspNetCore.Mvc;

namespace IntegrationTests;

public class IngredientsControllerTests(TestContextFixture fixture) : IClassFixture<TestContextFixture>
{
    private readonly TestContextFixture _fixture = fixture;
    private readonly IngredientsController _controller = new IngredientsController(new IngredientsRepository(fixture.FoodContext), fixture.Mapper);
    
    
    [Fact]
    public async Task GetAllIngredients_ReturnsList()
    {
        //Arrange

        //Act
        var result = await _controller.Get();

        //Assert
        result.Should().BeAssignableTo(typeof(IEnumerable<IngredientDTO>));
        result.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetIngredientsById_ReturnsIngredientById_Success()
    {
        //Arrange
        var testIngredient = fixture.FoodContext.Ingredients.First();
        
        //Act
        var response = await _controller.Get(testIngredient.Id);
        
        //Assert
        var result = response.Should().BeOfType<OkObjectResult>();
        IngredientDTO ingredient = result.Subject.Value.Should().BeAssignableTo<IngredientDTO>().Subject;
        ingredient.Name.Should().BeEquivalentTo(testIngredient.Name);
    }
    
    [Fact]
    public async Task GetIngredientsById_ReturnsIngredientById_NotFound()
    {
        //Arrange
        var mockRepo = new Mock<IIngredientsRepository>();
        var controller = new IngredientsController(mockRepo.Object, fixture.Mapper);
        
        //Act
        var result = await controller.Get(0);
        
        //Assert
        Assert.IsType<NotFoundResult>(result);
    }
}