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
        public Fighter target;

        public Basic()
        {
            enemies = new List<Actor>();
            this.owner = null;
            this.fighter = null;
            this.target = null;
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
                this.fighter = this.owner.findRole<Fighter>() as Fighter;

            int state_ = this.fighter.State;

            if ((LifeState)this.fighter.State == LifeState.Live)
            {
                search();

                foreach(Actor enemy in this.enemies)
                {
                    Fighter role_ = enemy.findRole<Fighter>() as Fighter;

                    if (role_.curHP > role_.damTaken)
                    {
                        target = role_;
                        this.fighter.attack(role_);
                        this.owner.notify(EVENT.ATTACK);
                        break;
                    }
                }
            }
        }
    }
}
