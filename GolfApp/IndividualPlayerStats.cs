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
        private int gameId;

        public IndividualPlayerStats(int gameId)
        {
            InitializeComponent();
            this.gameId = gameId;
        }

        private void IndividualPlayerStats_Load(object sender, EventArgs e)
        {
            GolfDB dB = new GolfDB();
            Game g = dB.Games.Include("Holes").Where(a => a.GameId == gameId).SingleOrDefault();
            List<Hole> holes = g.Holes;
            int count = 1;
            foreach (Hole H in holes)
            {
                this.chart1.Series[""].Points.AddXY(count, H.Par);
                this.chart1.Series[""].Points.AddXY(count, H.TotalShots);
                count++;

            }
        }
    }
}
