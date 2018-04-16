using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Combat_Sim
{
    public enum Side
    {
        Reds,
        Blues
    }

    public enum LifeState
    {
        Live,
        Dead 
    }

    public enum WarState
    {
        Engage,
        Win,
        Lose,
        Parity
    }

    public partial class Form1 : Form
    {
        Battlefield field;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(field != null)
            {
                int State = (int)WarState.Engage;
                chart1.Series.Clear();
                chart1.Series.Add("Reds");
                chart1.Series.Add("Blues");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                chart1.Series[1].ChartType = SeriesChartType.Line;
                chart1.Series[0].Color = Color.Red;
                chart1.Series[1].Color = Color.Blue;
                chart1.Series[0].BorderWidth = 2;
                chart1.Series[1].BorderWidth = 2;


                while (State == (int)WarState.Engage)
                {
                    field.census();
                    field.collision();
                    field.update();

                    

                    chart1.Series[0].Points.AddY(field.historyReds.Last());
                    chart1.Series[1].Points.AddY(field.historyBlues.Last());

                    if (field.historyBlues.Last() == 0 || field.historyReds.Last() == 0)
                    {
                        if(field.historyReds.Last() > field.historyBlues.Last())
                        {
                            State = (int)WarState.Win;
                        }
                        else if (field.historyReds.Last() < field.historyBlues.Last())
                        {
                            State = (int)WarState.Lose;
                        }
                        else
                        {
                            State = (int)WarState.Parity;
                        }
                    }
                }

                textBox1.Text = field.news;

            }
       }

        private void button1_Click(object sender, EventArgs e)
        {
            int numA = (int)numericNumReds.Value;
            int numB = (int)numericNumBlues.Value;

            int hpRed = (int)numHpReds.Value;
            int hpBlues = (int)numHpBlues.Value;

            int powerRed = (int)numPowerReds.Value;
            int powerBlue = (int)numPowerBlues.Value;

            List<Actor> Ateam = new List<Actor>();
            List<Actor> Bteam = new List<Actor>();

            for (var i = 0; i < numA; i++)
            {
                Ateam.Add(new Actor("Reds #" + (i + 1).ToString()));
                Ateam[i].addAI(new Basic());
                Ateam[i].addRole(new Fighter(hpRed, powerRed));
            }

            for (var j = 0; j < numB; j++)
            {
                Bteam.Add(new Actor("Blues #" + (j + 1).ToString()));
                Bteam[j].addAI(new Basic());
                Bteam[j].addRole(new Fighter(hpBlues, powerBlue));
            }

            field = new Battlefield(Ateam, Bteam);
        }
    }
}
