namespace Asteroid.Test
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}