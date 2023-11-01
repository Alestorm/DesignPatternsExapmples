using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.FactoryAnimals
{
    public class VacaCreator : IAnimalCreator
    {
        public Animal CreateAnimal()
        {
            return new Vaca();
        }
    }
}
