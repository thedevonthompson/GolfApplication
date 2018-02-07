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
        //create an empty game object
        Game game;
        //create an empty user object
        User user;

        //open new game form, pass the game and user in
        public frmNewGame(User u, Game g)
        {
            InitializeComponent();
            this.game = g;
        }

        private void frmNewGame_Load(object sender, EventArgs e)
        {
            //set the current hole to the 1st one
            game.currHole = 1;
        }

        private void UpdateForm()
        {
            //hide back button if on first hole
            if(game.currHole == 1)
            {
                btnPrevious.Visible = false;
            }
            //hide next button if on last hole
            if(game.currHole == 18)
            {
                btnNext.Visible = false;
                btnFinishGame.Visible = true;
            }



        }

        
    }
}
