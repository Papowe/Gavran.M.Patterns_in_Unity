using UnityEngine;

namespace Asteroid.Test
{
    public class ConsoleInput : IInput
    {
        public string Name => nameof(ConsoleInput);
    }
}