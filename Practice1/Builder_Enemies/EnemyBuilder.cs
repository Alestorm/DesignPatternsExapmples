using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Builder_Enemies
{
    public class EnemyBuilder : IEnemyBuilder
    {
        private Enemy _enemy = new Enemy();

        public Enemy Build()
        {
            return _enemy;
        }

        public IEnemyBuilder SetCanShoot(bool canShoot)
        {
            _enemy.CanShoot = canShoot;
            return this;
        }

        public IEnemyBuilder SetHealth(int health)
        {
            _enemy.Health = health;
            return this;
        }

        public IEnemyBuilder SetIsMoving(bool isMoving)
        {
            _enemy.IsMoving = isMoving;
            return this;
        }

        public IEnemyBuilder SetSpeed(int speed)
        {
            _enemy.Speed = speed;
            return this;
        }
    }
}
