using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public enum EVENT
    {
        DEAD = 0,
        ATTACK = 1,
        MOVE = 2,
   }

    public interface IObservable
    {
        void onNotify(EVENT e, Object o);
    }
}
