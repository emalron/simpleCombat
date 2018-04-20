using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Sim
{
    public class News
    {
        private List<string> survivors;
        public List<string> history;
        public List<int> histRedSurvived;
        public List<int> histBlueSurvived;

        private Battlefield field;

        delegate int FindingFighter(Actor o);
        
        public News(Battlefield field)
        {
            this.field = field;
            this.survivors = new List<string>();
            this.history = new List<string>();
            this.histBlueSurvived = new List<int>();
            this.histRedSurvived = new List<int>();

            var survs = from unit in this.field.sides
                        where (unit.findRole<Fighter>() as Fighter).State == (int)LifeState.Live
                        select unit.name;

            this.survivors = survs.ToList();
        }

        public void census()
        {
            var people = from unit in this.field.sides
                         where (unit.findRole<Fighter>() as Fighter).State == (int)LifeState.Dead
                         select unit;

            List<Actor> week = new List<Actor>(people.ToList());
            List<Actor> weeklydeads = new List<Actor>();
            List<int> killed = new List<int>();

            foreach(string s in this.survivors)
            {
                foreach(Actor j in week)
                {
                    if (j.name == s)
                    {
                        weeklydeads.Add(j);
                        killed.Add(this.survivors.IndexOf(s));
                    }
                }
            }

            foreach(int i in killed)
            {
                this.survivors[i] = "killed";
            }

            int reds = 0;
            int blues = 0;

            foreach(Actor o in this.field.sides)
            {
               if((o.findRole<Fighter>() as Fighter).State == (int)LifeState.Live)
                {
                    if(o.sideID == (int)Side.Reds)
                    {
                        reds++;
                    }
                    else
                    {
                        blues++;
                    }
                }
          }

            this.histBlueSurvived.Add(blues);
            this.histRedSurvived.Add(reds);

            foreach(Actor j in weeklydeads)
            {
                string turn = this.field.turn.ToString();
                string name = j.name;
                string msg = "[" + turn + "] " + name + " is dead\r\n";

                this.history.Add(msg);
            }
        }
    }
}
