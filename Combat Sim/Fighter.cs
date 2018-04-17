using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class Fighter : IRole
    {
        private Actor owner;
        public int State;
        private float HP;
        public float curHP;
        public float power;
        public float defense;
        public float prevDamTaken;
        public float damTaken;

        public Fighter(float life, float power)
        {
            this.HP = life;
            this.curHP = HP;
            this.power = power;
            this.damTaken = 0;
            this.prevDamTaken = 0;
            this.defense = 0;
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

                    this.owner.field.news.Add("[" + this.owner.field.turn +"] " + this.owner.name + " is dead\r\n");
                }

            }
        }
    }
}
