using UnityEngine;

namespace Asteroid
{
    public class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            //Enemy.CreateAsteroidEnemy(new Health(100f, 100f));
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
        }
    }
}