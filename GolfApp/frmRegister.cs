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

            User user = new User();

            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;

            db.Users.Add(user);
            if(db.SaveChanges() == 1)
            {
                MessageBox.Show("User saved!");
            }
            

        }
    }
}
 