using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Videogame
{
    public class Boss : IEnemy
    {
        public void DealDamage(int damageAmount)
        {
            Console.WriteLine($"Boss damage = {damageAmount}");
        }
    }
}
