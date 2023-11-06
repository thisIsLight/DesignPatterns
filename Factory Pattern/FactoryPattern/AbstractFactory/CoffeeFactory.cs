﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink MakeHotDrink(string Name)
        {
            return new Coffee(Name);
        }
    }
}
