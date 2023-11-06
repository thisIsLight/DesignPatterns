using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class TurnDoorFSM
    {
        public ITurnDoorState State = new UnlockedState();

        public void Coin() => State.Coin(this);
        public void Pass() => State.Pass(this);

        public void Unlock()
        {
            Console.WriteLine("Door Opened");
        }

        public void Lock()
        {
            Console.WriteLine("Door is Locked. Put Coin");
        }
    }
}
