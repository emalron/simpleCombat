﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public interface Iai
    {
        void action();
        void setOwner(Actor owner);
    }
}
