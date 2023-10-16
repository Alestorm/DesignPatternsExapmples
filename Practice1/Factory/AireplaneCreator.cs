using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.Factory
{
    public class AireplaneCreator : ITransportCreator
    {
        public ITransport CreateTransport()
        {
            return new Airplane();
        }
    }
}
