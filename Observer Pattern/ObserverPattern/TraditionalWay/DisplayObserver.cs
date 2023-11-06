using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.TraditionalWay
{
    public class DisplayObserver : IObservers
    {
        public void Update(int time)
        {
            UpdateDisplay(time);
        }

        private void UpdateDisplay(int time)
        {
            Console.WriteLine("--Display--");
            Console.WriteLine(time);
            Console.WriteLine("-----------");
        }
    }
}
