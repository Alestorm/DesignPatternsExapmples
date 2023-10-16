using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by truck");
        }
    }
}
