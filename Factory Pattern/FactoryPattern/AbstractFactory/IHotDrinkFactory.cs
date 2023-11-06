﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractFactory
{
    public interface IHotDrinkFactory
    {
        IHotDrink MakeHotDrink(string Name);
    }
}
