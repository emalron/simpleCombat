using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public interface IRole
    {
        void update();
        void setOwner(Actor owner);
    }
}
