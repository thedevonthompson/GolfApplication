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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            GolfDB db = new GolfDB();

            //create user to be saved
            User user = new User();


            //check to see if user is already present by username
            User testUser = DBHelper.GetUserByUsername(txtUsername.Text);
            if (testUser == null)
            {
                testUser.Username = txtUsername.Text;
                testUser.Password = txtPassword.Text;

                db.Users.Add(testUser);
                if (db.SaveChanges() == 1)
                {
                    MessageBox.Show("User saved!");
                }
            }
            else
            {
                MessageBox.Show("User already exists!");
            }
            
    


        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
