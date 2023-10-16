using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Videogame
{
    public class StrongEnemyCreator : IEnemyCreator
    {
        public IEnemy CreateEnemy()
        {
            return new StrongEnemy();
        }
    }
}
