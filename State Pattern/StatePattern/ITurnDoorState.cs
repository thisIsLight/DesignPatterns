using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface ITurnDoorState
    {
        void Coin(TurnDoorFSM currentState);
        void Pass(TurnDoorFSM currentState);
    }
}
