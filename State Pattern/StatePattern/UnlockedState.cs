using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class UnlockedState : ITurnDoorState
    {
        public void Coin(TurnDoorFSM currentState)
        {
            currentState.Unlock();
        }

        public void Pass(TurnDoorFSM currentState)
        {
            currentState.State = new LockedState();
            currentState.Lock();
        }
    }
}
