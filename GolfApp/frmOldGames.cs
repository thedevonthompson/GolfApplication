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
    public partial class frmOldGames : Form
    {
        User user = new User();
        public frmOldGames(User u)
        {
            InitializeComponent();
            user = u;

        }

        private void frmOldGames_Load(object sender, EventArgs e)
        {
            User user = new User();
            List<Game> games = DBHelper.GetAllGamesByUser(user);
            foreach(Game g in games)
            {
                lstOldGames.Items.Add(g.GameId);
            }
        }

        private void btnViewGame_Click(object sender, EventArgs e)
        {
            if(lstOldGames.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a game to view.");
            }
            else
            {
                var x = (int)lstOldGames.SelectedItem;
                
                Game g = DBHelper.GetGameById(x);
                frmViewGame frm = new frmViewGame(g);
            }
        }
    }
}
