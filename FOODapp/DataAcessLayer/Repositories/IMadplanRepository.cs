using DataAcessLayer.Models;

namespace DataAcessLayer.Repositories;

public interface IMadplanRepository
{
    Task<List<Madplan>> GetMadlans();
    Task<Madplan> GetMadPlan(int id);
    Task<Madplan> GetMadPlanByDate(DateOnly WeekYear);
    Task<List<Madplan>> GetMadByDateRange(DateOnly startDate, DateOnly endDate);
    Task<bool> MakeMadPlan(Madplan madplan);
    Task<bool> DeleteMadPlan(Madplan madplan);
    Task<bool> UpdateMadPlan(Madplan madplan);

}