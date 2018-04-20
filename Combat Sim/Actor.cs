using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{

    public class Actor : ICloneable
    {
        public string name;
        public List<Iai> aiList;
        public List<IRole> roleList;
        public Battlefield field;
        public int sideID;

        public Actor(string name)
        {
            this.name = name;
            this.aiList = new List<Iai>();
            this.roleList = new List<IRole>();
        }
        
        public void setBattlefield(Battlefield field)
        {
            this.field = field;
        }

        public void addRole(IRole role)
        {
            roleList.Add(role);
            role.setOwner(this);
        }            

        public void addAI(Iai ai)
        {
            aiList.Add(ai);
            ai.setOwner(this);
        }

        public void managerAI()
        {
            if(this.aiList.Count > 0)
            {
                aiList[0].action();
            }
        }

        public Object findRole<T>()
        {
            foreach(var o in this.roleList)
            {
                if(o is T)
                {
                    return o;
                }
            }
            return null;
        }

        public object Clone()
        {
            Actor actor = new Actor(this.name);
            actor.aiList = new List<Iai>(this.aiList);
            actor.roleList = new List<IRole>(this.roleList);
            actor.field = this.field;

            return actor;
        }
    }
}
