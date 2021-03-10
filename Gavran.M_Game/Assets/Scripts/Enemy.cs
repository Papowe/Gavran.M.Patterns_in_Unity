using UnityEngine;

namespace Asteroid
{
    public abstract class Enemy : MonoBehaviour
    {
        public Health Health { get; protected set; }
        
        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }
    }
}