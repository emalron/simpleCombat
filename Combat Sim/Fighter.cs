using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public struct Stat
    {
        public float HP;
        public float power;
        public float pos;
    }

    public class Fighter : IRole
    {
        public Actor owner;
        public int State;
        private float HP;
        public float curHP;
        public float power;
        public float defense;
        public float prevDamTaken;
        public float damTaken;
        public float moveRate;
        public float pos;

        public Fighter(Stat stat)
        {
            this.HP = stat.HP;
            this.curHP = HP;
            this.power = stat.power;
            this.pos = stat.pos;

            this.damTaken = 0;
            this.prevDamTaken = 0;
            this.defense = 0;
            this.moveRate = 1;
        }

        public void setOwner(Actor owner)
        {
            this.owner = owner;
            this.State = (int)LifeState.Live;
        }

        public void attack(Fighter enemy)
        {
            float damage_ = this.power - enemy.defense;

            if (damage_ > 0)
            {
                enemy.damTaken += damage_;
            }
        }

        public void update()
        {
            if ((LifeState)this.State == LifeState.Live)
            {
                this.curHP -= this.damTaken;
                this.prevDamTaken = this.damTaken;
                this.damTaken = 0;
                if (this.curHP <= 0)
                {
                    this.curHP = 0;
                    this.State = (int)LifeState.Dead;
                    this.owner.notify(EVENT.DEAD);
                }

            }
        }
    }
}
