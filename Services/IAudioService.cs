namespace CozyPortfolio.Services;

public interface IAudioService : IAsyncDisposable
{
    bool IsMuted { get; }
    event Action? MuteStateChanged;

    Task InitializeAsync();
    Task PlayMoodTrackAsync(string audioPath);
    Task ToggleMuteAsync();
}