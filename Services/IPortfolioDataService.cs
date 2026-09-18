namespace CozyPortfolio.Services;
using CozyPortfolio.Models;

public interface IPortfolioDataService
{
    IReadOnlyList<Project> GetProjects();
    IReadOnlyList<Skill> GetSkills();
    IReadOnlyList<MoodState> GetMoodStates();
}