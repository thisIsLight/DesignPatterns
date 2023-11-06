using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.TraditionalWay
{
    public class Watch : Observable
    {
        public int time = 0;
        public int GetTime()
        {
            return ++time;
        }

        public void TimeCounter()
        {
            while(time < 100)
            {
                BroadCast(GetTime());
                Thread.Sleep(100);
            }
        }
    }
}
