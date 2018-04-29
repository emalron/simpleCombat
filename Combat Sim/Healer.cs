using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class Healer
    {
        public string type;
        public float healrate;
        private Actor owner;

        public Healer()
        {
            this.type = "Healer";
            this.healrate = 1.0f;
        }

        public void setOwner(Actor owner)
        {
            this.owner = owner;
        }
    }
}
