using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProofOfEvidence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Users myUser = new Users();
            string usernameInput = tbUser.Text;
            string passwordInput = tbPass.Text;
            List<Users> allUsers = myUser.AddUser();
            bool userFound = false;

            string userdisplay = "";
            foreach (Users userInstance in allUsers)
            {

                if (usernameInput == userInstance.Username && passwordInput == userInstance.Password)
                {
                    userFound = true;
                    userdisplay = userInstance.Rank + " " + userInstance.Username + "\n" +userInstance.Callsign + "\n"+ userInstance.Unit;
                }
            }

            if (userFound == true)
            {
                
                MainInterface MainMenu = new MainInterface(userdisplay);
                MainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and password combination was incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
