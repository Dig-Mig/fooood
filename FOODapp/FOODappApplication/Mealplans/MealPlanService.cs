using AutoMapper;
using DataAcessLayer.Models;
using DataAcessLayer.Repositories;

namespace FOODappApplication.Mealplans;

public class MealPlanService : IMealPlanService
{
    private IMealPlanRepository _repository;
    private IMapper _mapper;

    public MealPlanService(IMealPlanRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;

    }

    public async Task<List<MealPlanDto>> getAllMealPlans()
    {
        var result = await _repository.GetMealPlan();
        return _mapper.Map<List<MealPlan>, List<MealPlanDto>>( result);
    }
}