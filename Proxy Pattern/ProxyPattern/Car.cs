﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Car : ICar
    {
        public string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
        public void Drive()
        {
            Console.WriteLine("Wrooommmm");
        }
    }
}
