using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfApp
{
    public partial class IndividualPlayerStats : Form
    {
        private Game game;

        public IndividualPlayerStats(Game g)
        {
            InitializeComponent();
            game = g;
        }

        private void IndividualPlayerStats_Load(object sender, EventArgs e)
        {

            List<int> shots = game.GetListTotalShots();
            List<Point> points = new List<Point>();

            for (int i = 1; i <= shots.Count; i++)
            {
                points.Add(new Point(i, shots[i-1]));
            }

            chart1.DataSource = points;

            chart1.Series["Game"].XValueMember = "X";
            chart1.Series["Game"].YValueMembers = "Y";

            chart1.DataBind();

            //chart1.DataSource = shots;
            //chart1.DataBind();
            //chart1.Series["Game"].Points.DataBind(points, "X", "Y", null);

            //chart1.DataBindTable(points, "Shots");
            //chart1.DataSource = shots;

            //int count = 1;


            //foreach (Hole H in holes)
            //{
            //    this.chart1.Series[""].Points.AddXY(count, H.Par);
            //    this.chart1.Series[""].Points.AddXY(count, H.TotalShots);
            //    count++;

            //}
        }
    }
}
