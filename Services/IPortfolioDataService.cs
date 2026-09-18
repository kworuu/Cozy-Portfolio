using CozyPortfolio.Models;
namespace CozyPortfolio.Services;

public interface IPortfolioDataService
{
    IReadOnlyList<Project> GetProjects();
    IReadOnlyList<Skill> GetSkills();
    IReadOnlyList<MoodState> GetMoodStates();
}