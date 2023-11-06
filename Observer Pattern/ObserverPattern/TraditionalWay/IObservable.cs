using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.TraditionalWay
{
    public abstract class Observable
    {
        public List<IObservers> Observers;

        public Observable()
        {
            Observers = new List<IObservers>();
        }

        public void Subscribe(IObservers observer)
        {
            Observers.Add(observer);
        }

        public void Unsubscribe(IObservers observer)
        {
            Observers.Remove(observer);
        }

        public void BroadCast(int time)
        {
            Observers.ForEach(x =>
            {
                x.Update(time);
            });
        }
    }
}
