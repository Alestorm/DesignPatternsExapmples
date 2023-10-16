using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Videogame
{
    public class WeakEnemy : IEnemy
    {
        public void DealDamage(int damageAmount)
        {
            Console.WriteLine($"Weak enemy damage = {damageAmount}");
        }
    }
}
