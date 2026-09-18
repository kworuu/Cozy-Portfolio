using CozyPortfolio.Models;
namespace CozyPortfolio.Services;

public class PortfolioDataService : IPortfolioDataService
{
    private readonly List<Project> _projects = new()
    {
        new Project("Cozy Weather", "A warm, minimal weather dashboard showing hourly forecasts, UV index, and mood-matched wallpapers.", new[] { "Blazor WASM", "C#", ".NET 8" }, "☁️"),
        new Project("Pixel Garden", "Procedurally generated pixel-art gardens. Grow plants, earn seeds, water neighbors' plots in real time.", new[] { "C#", "SignalR", "HTML Canvas" }, "🌱"),
        new Project("Note Nook", "A warm-toned note-taking app with rich text editing, tagging, and daily journal prompts.", new[] { "Blazor Server", "SQLite", "EF Core" }, "📝")
    };

    private readonly List<Skill> _skills = new()
    {
        new Skill("C# / .NET 8", "⚡"), new Skill("Blazor WebAssembly", "🌐"),
        new Skill("HTML & CSS", "🎨"), new Skill("TypeScript", "📜"),
        new Skill("SQL & EF Core", "🗄️"), new Skill("Git & GitHub", "🐙"),
        new Skill("Python", "🐍"), new Skill("Java", "☕")
    };

    private readonly List<MoodState> _moodStates = new()
    {
        new MoodState("Happy", "Welcome to my cozy corner of the internet! I'm so glad you stopped by~", "images/mascot/happy.jpg", "theme-pink", "☀️"),
        new MoodState("Sleepy", "...oh! You came to visit? Excuse me, I was just resting...", "images/mascot/sleepy.jpg", "theme-blue", "🌙"),
        new MoodState("Cool", "Hey. Cool of you to stop by. Check out what I've been building lately.", "images/mascot/cool.jpg", "theme-green", "🎧")
    };

    public IReadOnlyList<Project> GetProjects() => _projects;
    public IReadOnlyList<Skill> GetSkills() => _skills;
    public IReadOnlyList<MoodState> GetMoodStates() => _moodStates;
}