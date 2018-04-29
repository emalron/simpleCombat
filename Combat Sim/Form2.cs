using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Sim
{
    public partial class Form2 : Form
    {
        List<Actor> sides;
        Image red, blue;
        int[] nums;

        public Form2()
        {
            InitializeComponent();

            // this.Size = new Size(new Point(620, 361));
            this.pictureBox1.Image = Properties.Resources.world;

            this.red = Properties.Resources.red;
            this.blue = Properties.Resources.blue;

            sides = new List<Actor>();
            nums = new int[2];
        }

        public void makeEntities(List<Actor> sides)
        {
            this.sides = sides;
        }

        void whoseSideRUon()
        {
            var red = from unit in this.sides
                      where (unit.findRole<Fighter>() as Fighter).State == (int)LifeState.Live
                      where unit.sideID == (int)Side.Reds
                      select unit;
            var blue = from unit in this.sides
                      where (unit.findRole<Fighter>() as Fighter).State == (int)LifeState.Live
                      where unit.sideID == (int)Side.Blues
                      select unit;

            nums[0] = red.Count();
            nums[1] = blue.Count();
        }

        public void render()
        {
            float wWid, wHei, cWid, cHei;
            
            wWid = this.pictureBox1.Size.Width;
            wHei = this.pictureBox1.Size.Height;

            cWid = this.red.Width;
            cHei = this.red.Height;

            whoseSideRUon();

            Graphics g = Graphics.FromImage(this.pictureBox1.Image);

            // draw background
            g.DrawImage(Properties.Resources.world, 0, 0);

            // draw red
            for(int i=0;i<nums[0];i++)
            {
                g.DrawImage(this.red, (cWid + cWid), (2f*cHei + 2f*i * cHei));
            }
            for (int j = 0; j < nums[1]; j++)
            {
                g.DrawImage(this.blue, (wWid -2f* cWid), (2f * cHei + 2f*j * cHei));
            }

            pictureBox1.Refresh();
        }
    }
}
