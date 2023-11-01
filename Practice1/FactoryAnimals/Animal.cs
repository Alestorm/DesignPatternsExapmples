﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.FactoryAnimals
{
    public abstract class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}