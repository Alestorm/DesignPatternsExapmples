using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Builder_Enemies
{
    public class Enemy
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public bool IsMoving { get; set; }
        public bool CanShoot { get; set; }
    }
}
