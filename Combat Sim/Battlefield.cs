using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class Battlefield
    {
        public List<Actor> sides;
        public List<int> historyReds;
        public List<int> historyBlues;
        public List<string> news;
        public int turn;

        public Battlefield(List<Actor> reds, List<Actor> blues)
        {
            sides = new List<Actor>();

            this.news = new List<string>();

            this.turn = 0;

            reds.ForEach(x =>
            {
                x.sideID = (int)Side.Reds;
                x.field = this;
                this.sides.Add(x);
                x.setBattlefield(this);
            }
            );
            blues.ForEach(x =>
            {
                x.sideID = (int)Side.Blues;
                x.field = this;
                this.sides.Add(x);
                x.setBattlefield(this);
            });

            historyBlues = new List<int>();
            historyReds = new List<int>();
        }

        public void collision()
        {
            sides.ForEach(x =>
            {
                var xai = from basic in x.aiList
                          where basic is Basic
                          select basic as Basic;

                xai.First().action();
            });
        }

        public void update()
        {
            sides.ForEach(x =>
           {
               x.roleList.ForEach(y =>
               {
                   y.update();
               });
           });
            this.turn++;
        }

        public void census()
        {
            int numReds = 0;
            int numBlues = 0;

            foreach(Actor actor in this.sides)
            {
                var fighter = from role in actor.roleList
                              where role is Fighter
                              select role as Fighter;
                
                if(fighter.First().State == (int)LifeState.Live)
                {
                    if(actor.sideID == (int)Side.Reds)
                    {
                        numReds++;
                    }
                    else
                    {
                        numBlues++;
                    }
                }
            }
            
            historyReds.Add(numReds);
            historyBlues.Add(numBlues);
        }
    }
}
