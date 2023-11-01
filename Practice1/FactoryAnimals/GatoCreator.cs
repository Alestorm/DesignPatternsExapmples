using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.FactoryAnimals
{
    public class GatoCreator : IAnimalCreator
    {
        public Animal CreateAnimal()
        {
            return new Gato();
        }
    }
}
