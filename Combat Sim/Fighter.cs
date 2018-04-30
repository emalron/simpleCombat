using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    enum Mode
    {
        MOVE = 0,
        ATTACK = 1,
    }
    public struct Stat
    {
        public float HP;
        public float power;
        public float range;
        public float moveRate;
        public float pos;
    }

    public class Fighter : IRole
    {
        public Actor owner;
        private List<Actor> enemies;
        public Fighter target;
        public int State;
        public int mode;
        private float HP;
        public float curHP;
        public float power;
        public float defense;
        public float prevDamTaken;
        public float damTaken;
        public float moveRate;
        public float pos;
        public float newPos;
        public float range;

        public Fighter(Stat stat)
        {
            enemies = new List<Actor>();

            this.HP = stat.HP;
            this.curHP = HP;
            this.power = stat.power;
            this.pos = stat.pos;
            this.damTaken = 0;
            this.prevDamTaken = 0;
            this.defense = 0;
            this.moveRate = stat.moveRate;
            this.range = stat.range;
        }

        public void setOwner(Actor owner)
        {
            this.owner = owner;
            this.State = (int)LifeState.Live;
        }

        private void search()
        {
            this.enemies.Clear();

            var enemies_ = from unit in this.owner.field.sides
                           where unit.sideID != this.owner.sideID
                           where (unit.findRole<Fighter>() as Fighter).State.Equals((int)LifeState.Live)
                           orderby (unit.findRole<Fighter>() as Fighter).power/(unit.findRole<Fighter>() as Fighter).curHP descending
                           select unit;

            this.enemies = enemies_.ToList<Actor>();
        }

        public void execute()
        {
            if (this.State == (int)LifeState.Live)
            {
                search();
                if (enemies.Count != 0)
                {
                    Fighter target = enemies[0].findRole<Fighter>() as Fighter;
                    if (moveFowardTo(target) is false)
                    {
                        moveTo(target);
                    }
                    else
                    {
                        attackWho();
                    }
                }
            }
        }

        public void attack(Fighter enemy)
        {
            float damage_ = this.power - enemy.defense;

            if (damage_ > 0)
            {
                enemy.damTaken += damage_;
            }
        }

        public bool moveFowardTo(Fighter target)
        {
            // get the distance between me and the target.
            float locMe_ = this.pos;
            float locTarget_ = target.pos;

            float dist_ = Math.Abs(locTarget_ - locMe_);

            // Is the distacne smaller than my move rate?
            if (dist_ <= this.range)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public void attackWho()
        {
            foreach (var enemy in this.enemies)
            {
                var role_ = enemy.findRole<Fighter>() as Fighter;

                // no overkill check
                if (role_.curHP > role_.damTaken)
                {
                    this.mode = (int)Mode.ATTACK;

                    this.target = role_;
                    this.attack(role_);
                    this.owner.notify(EVENT.ATTACK);
                    break;
                }
            }
        }

        public void moveTo(Fighter target)
        {
            // check if I'm in the target area
            if (this.pos > target.pos)
            {
                this.mode = (int)Mode.MOVE;

                this.newPos = this.pos - this.moveRate;
                this.owner.notify(EVENT.MOVE);
            }
            else
            {
                this.mode = (int)Mode.MOVE;

                this.newPos = this.pos + this.moveRate;
                this.owner.notify(EVENT.MOVE);
            }
        }

        public void update()
        {
            if (this.mode == (int)Mode.ATTACK)
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
            if(this.mode == (int)Mode.MOVE)
            {
                this.pos = this.newPos;
            }
        }
    }
}
