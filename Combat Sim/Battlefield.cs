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
        public int turn;

        public Battlefield(List<Actor> reds, List<Actor> blues)
        {
            sides = new List<Actor>();
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
    }
}
