using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class CarProxyWithAgeLimitation : Car
    {
        public int Age;
        public CarProxyWithAgeLimitation(string name, int age) : base(name)
        {
            Age = age;
        }

        public void Drive()
        {
            if(Age < 18)
            {
                Console.WriteLine("You cannot drive a car");
                return;
            }
            else
            {
                base.Drive();
            }
        }
    }
}
