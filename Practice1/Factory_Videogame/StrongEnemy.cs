﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory_Videogame
{
    public class StrongEnemy : IEnemy
    {
        public void DealDamage(int damageAmount)
        {
            Console.WriteLine($"Strong enemy damage = {damageAmount}");
        }
    }
}
