using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LockedState : ITurnDoorState
    {
        public void Coin(TurnDoorFSM currentState)
        {
            currentState.State = new UnlockedState();
            currentState.Unlock();
        }

        public void Pass(TurnDoorFSM currentState)
        {
            currentState.Lock();
        }
    }
}
