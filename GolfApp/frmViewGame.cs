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
    public partial class frmViewGame : Form
    {
        Game game = new Game();
        public frmViewGame(Game g)
        {
            InitializeComponent();
            this.game = g;
        }

        private void frmViewGame_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 19; i++)
            {
                lstHoles.Items.Add($"Hole: {i}");
            }
        }
    }
}
