using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class News : IObservable
    {
        public struct History
        {
            public int turn;
            public EVENT type;
            public Side side;
            public string name;
            public string news;
        }

        private List<string> survivors;
        public List<History> history;
        public int histRedSurvived;
        public int histBlueSurvived;

        private Battlefield field;

        delegate int FindingFighter(Actor o);
        
        public News(Battlefield field)
        {
            this.field = field;
            this.survivors = new List<string>();
            this.history = new List<History>();

            foreach(var o in this.field.sides)
            {
                if(o.sideID == (int)Side.Reds)
                {
                    this.histRedSurvived++;
                }
                else if(o.sideID == (int)Side.Blues)
                {
                    this.histBlueSurvived++;
                }
            }
            
            var survs = from unit in this.field.sides
                        where (unit.findRole<Fighter>() as Fighter).State == (int)LifeState.Live
                        select unit.name;

            this.survivors = survs.ToList();
        }
        
        public void onNotify(EVENT e, Object o)
        {
            switch(e)
            {
                case EVENT.DEAD:
                    onEventDead(o);
                    break;
                case EVENT.ATTACK:
                    break;
                case EVENT.MOVE:
                    break;
            }
        }

        public void onEventDead(Object o)
        {
            if(o is Actor)
            {
                Actor a_ = o as Actor;
                history.Add(new History
                {
                    turn = this.field.turn,
                    type = EVENT.DEAD,
                    name = a_.name,
                    side = (Side)a_.sideID,
                    news = "[" + (this.field.turn + 1) + "] " + a_.name + " is dead.\r\n",
                });

                if (a_.sideID == (int)Side.Reds)
                {
                    this.histRedSurvived--;
                }
                else if (a_.sideID == (int)Side.Blues)
                {
                    this.histBlueSurvived--;
                }
            }
        }

        public void onEventAttack(Object o)
        {
            if (o is Actor)
            {
                Actor a_ = o as Actor;
                Fighter fighter_ = a_.findRole<Fighter>() as Fighter;

                if (fighter_.target != null) {
                    history.Add(new History
                    {
                        turn = this.field.turn,
                        type = EVENT.ATTACK,
                        name = a_.name,
                        side = (Side)a_.sideID,
                        news = "[" + (this.field.turn+1) + "] " + a_.name + " attacked " + fighter_.target.owner.name + "\r\n",
                    });
                }
            }
        }

        public void onEventMove(Object o)
        {
            if (o is Actor)
            {
                Actor a_ = o as Actor;
                Fighter f_ = a_.findRole<Fighter>() as Fighter;

                history.Add(new History
                {
                    turn = this.field.turn,
                    type = EVENT.MOVE,
                    name = a_.name,
                    side = (Side)a_.sideID,
                    news = "[" + (this.field.turn+1) + "] " + a_.name + " moved.\r\n",
                });
            }
        }
    }
}
