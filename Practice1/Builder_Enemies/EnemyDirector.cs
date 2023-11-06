using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Builder_Enemies
{
    public class EnemyDirector
    {
        public Enemy BuildBoss(EnemyBuilder enemyBuilder)
        {
            return enemyBuilder
                .SetHealth(200)
                .SetCanShoot(true)
                .SetSpeed(0)
                .SetIsMoving(false)
                .Build();
        }
        public Enemy BuildWalkingEnemy(EnemyBuilder enemyBuilder)
        {
            return enemyBuilder
                .SetHealth(10)
                .SetCanShoot(true)
                .SetSpeed(10)
                .SetIsMoving(true)
                .Build();
        }
    }
}
