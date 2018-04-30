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
        News news;
        Form2 worldForm;

        public Form1()
        {
            InitializeComponent();

            worldForm = new Form2();
            worldForm.Show();
        }

        private void chartInit()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Reds");
            chart1.Series.Add("Blues");
            chart1.Series[0].ChartType = SeriesChartType.StepLine;
            chart1.Series[1].ChartType = SeriesChartType.StepLine;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;

            chartInput();
        }

        private void chartInput()
        {
            chart1.Series[0].Points.AddXY(field.turn, news.histRedSurvived);
            chart1.Series[1].Points.AddXY(field.turn, news.histBlueSurvived);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (field != null)
            {
                int State = (int)WarState.Engage;

                chartInit();

                while (State == (int)WarState.Engage)
                {
                    State = simulate(State);
                }

                /*
                for(int i=0; i<10; i++)
                {
                    State = simulate(State);
                }
                */


                broadcast();
            }
        }

        int simulate(int state)
        {
            int State = state;

            field.collision();
            field.update();

            chartInput();

            if (news.histBlueSurvived == 0 || news.histRedSurvived == 0)
            {
                if (news.histRedSurvived > news.histBlueSurvived)
                {
                    State = (int)WarState.Win;
                }
                else if (news.histRedSurvived < news.histBlueSurvived)
                {
                    State = (int)WarState.Lose;
                }
                else
                {
                    State = (int)WarState.Parity;
                }
            }

            return State;
        }

        private void broadcast()
        {
            richTextBox1.Font = new Font("Consolas", 10f, FontStyle.Regular);

            var output = from line in news.history
                         where line.type == EVENT.DEAD || line.type == EVENT.MOVE || line.type == EVENT.ATTACK
                         select line;

            output.ToList();

            foreach(var line in output)
            {
                if(line.side == Side.Reds)
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText(line.news);
                }

                if(line.side == Side.Blues)
                {
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.AppendText(line.news);
                }
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

            int rateRed = (int)numSpeedReds.Value;
            int rateBlue = (int)numSpeedBlues.Value;

            int rangeRed = (int)numRangeReds.Value;
            int rangeBlue = (int)numRangeBlues.Value;

            int posRed = (int)numPosReds.Value;
            int posBlue = (int)numPosBlues.Value;

            List<Actor> Ateam = new List<Actor>();
            List<Actor> Bteam = new List<Actor>();

            for (var i = 0; i < numA; i++)
            {
                Ateam.Add(new Actor("Reds #" + (i + 1).ToString()));
                Ateam[i].addRole(new Fighter(new Stat { HP = hpRed, power = powerRed, pos=posRed, moveRate=rateRed, range=rangeRed }));
            }

            for (var j = 0; j < numB; j++)
            {
                Bteam.Add(new Actor("Blues #" + (j + 1).ToString()));
                Bteam[j].addRole(new Fighter(new Stat { HP = hpBlues, power = powerBlue, pos=posBlue, moveRate=rateBlue, range=rangeBlue }));
            }

            field = new Battlefield(Ateam, Bteam);

            news = new News(field);

            foreach(var o in field.sides)
            {
                o.addObserver(news);
            }

            richTextBox1.Text = "";

            // worldForm.makeEntities(field.sides);
            // worldForm.render();
        }
    }
}
