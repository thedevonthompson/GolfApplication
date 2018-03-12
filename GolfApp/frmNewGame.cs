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
    public partial class frmNewGame : Form
    {
        //instantiate currHole
        int numHole = 1;
        
        //create an empty game object
        Game game = new Game();

        //create an empty user object
        User user = new User();

        public Hole currHole = new Hole();
        //open new game form, pass the game and user in
        public frmNewGame(User u)
        {
            InitializeComponent();
            this.user = u;
            this.currHole = new Hole();
        }

        private void frmNewGame_Load(object sender, EventArgs e)
        {
            game = Game.GetNewGame();

            //set the current hole to the 1st one

            labHole.Text = $"Hole: {numHole}";
            game.UserId.UserId = user.UserId;
        }

        private void UpdateForm()
        {
            //hide back button if on first hole
            if (numHole == 1)
            {
                btnPrevious.Visible = false;
            }
            //hide next button if on last hole
            if (numHole == 18)
            {
                btnNext.Visible = false;
                btnFinishGame.Visible = true;
            }
            labHole.Text = $"Hole: {numHole}";
            
        }

        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            var db = new GolfDB();

            db.Games.Add(game);

            db.SaveChanges();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            numHole--;
            UpdateForm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveHole();
            game.Holes[numHole] = currHole;

            numHole++;
            UpdateForm();
        }

        public void SaveHole()
        {
            //here is where all the decisions and magic happens

            //get the type of drive
            currHole.DriveType = lstDrive.SelectedItem.ToString();

            if(lstFairway.SelectedItem.ToString() == "Yes")
            {
                currHole.OnFairway = true;
            }
            else if(lstFairway.SelectedItem.ToString() == "No")
            {
                currHole.OnFairway = false;
            }

            int strokesToGreen = Convert.ToInt32(lstGreenShots.SelectedItem.ToString());

            if(currHole.Par - strokesToGreen < 2)
            {
                currHole.InRegulation = false;
            }
            else
            {
                currHole.InRegulation = true;
            }

            currHole.TotalShots = Convert.ToInt32(lstTotalShots
                                  .SelectedItem.ToString());

            currHole.NumPutts = currHole.TotalShots - strokesToGreen;

            game.Holes[numHole - 1] = currHole;
        }

    }
}
