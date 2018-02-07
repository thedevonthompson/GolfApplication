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
    public partial class frmHome : Form
    {
        User u = new User();
        public frmHome(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //create a new game instance
            Game g = new Game();

        }
    }
}
