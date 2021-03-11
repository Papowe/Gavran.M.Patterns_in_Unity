using UnityEngine;

namespace Asteroid
{
    internal static class NameManager
    {
        public const string POOL_AMMUNITION = "[Pool_amunition]";

        private static string[] _namesEnemses = {"Asteroid0", "Asteroid1", "Asteroid2"};

        public static string GetRandomNameEnemies()
        {
            return _namesEnemses[Random.Range(0, _namesEnemses.Length)];
        }
    }
}