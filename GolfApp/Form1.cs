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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Alright, let's log in
            User currentUser = DBHelper.GetUserByUsername(txtUsername.Text);
            if(currentUser == null)
            {
                MessageBox.Show("That user was not found");
            }
            else if(currentUser.Password != txtPassword.Text)
            {
                MessageBox.Show("That password is incorrect");
            }
            else
            {
                frmHome home = new frmHome(currentUser);
                home.ShowDialog();
                this.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open register form
            frmRegister form = new frmRegister();
            form.ShowDialog();
        }
    }


}
