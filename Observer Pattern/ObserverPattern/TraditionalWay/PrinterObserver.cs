using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.TraditionalWay
{
    public class PrinterObserver : IObservers
    {
        public int currentTime = 0;
        public void Update(int time)
        {
            PrintingTime(time);
        }

        public void PrintingTime(int time)
        {
            Console.WriteLine($"Printing job started since time changed {time}");
        }
    }
}
