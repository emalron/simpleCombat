using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class Basic : Iai
    {
        private Actor owner;
        private Fighter fighter;
        private List<Actor> enemies;

        public Basic()
        {
            enemies = new List<Actor>();
            this.owner = null;
            this.fighter = null;
        }

        private Fighter findFighter(Actor actor)
        {
            var xrole = from role in actor.roleList
                        where role is Fighter
                        select role as Fighter;

            return xrole.First();
        }

        public void setOwner(Actor owner)
        {
            this.owner = owner;
        }

        private void search()
        {
            this.enemies.Clear();

            var enemies_ = from unit in this.owner.field.sides
                           where unit.sideID != this.owner.sideID
                           where this.fighter.State.Equals((int)LifeState.Live)
                           orderby this.fighter.power/this.fighter.curHP descending
                           select unit;

            this.enemies = enemies_.ToList<Actor>();
        }

        public void action() {
            if (this.owner != null && this.fighter == null)
                this.fighter = findFighter(this.owner);

            int state_ = this.fighter.State;

            if ((LifeState)this.fighter.State == LifeState.Live)
            {
                search();

                foreach(Actor enemy in this.enemies)
                {
                    Fighter role_ = findFighter(enemy);

                    if (role_.curHP > role_.damTaken)
                    {
                        this.fighter.attack(role_);
                        break;
                    }
                }
            }
        }
    }
}
