using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Builder_Enemies
{
    public interface IEnemyBuilder
    {
        public IEnemyBuilder SetHealth(int health);
        public IEnemyBuilder SetSpeed(int speed);
        public IEnemyBuilder SetIsMoving(bool isMoving);
        public IEnemyBuilder SetCanShoot(bool canShoot);
        public Enemy Build();
    }
}
