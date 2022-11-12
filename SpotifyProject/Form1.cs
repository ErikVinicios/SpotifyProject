using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SpotifyProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void btSignIn_Click(object sender, EventArgs e)
        {
            MySqlDataReader dr = SQLCommands.Read();
            lbInvUsername.Visible = false;
            lbInvPassword.Visible = false;
            while (dr.Read())
            {
                if (dr["Username"].ToString() == tbUsername.Text)
                {
                    if (dr["Password"].ToString() == tbPassword.Text)
                    {
                        MessageBox.Show("Login successfully!", "CONGRATULATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbUsername.Text = "Username";
                        tbUsername.ForeColor = Color.DarkGray;
                        tbPassword.PasswordChar = '\0';
                        tbPassword.Text = "Password";
                        tbPassword.ForeColor = Color.DarkGray;
                        return;
                    }
                    lbInvPassword.Visible = true;
                    lbInvPassword.Text = "* Incorrect password";
                    tbPassword.PasswordChar = '\0';
                    tbPassword.Text = "Password";
                    tbPassword.ForeColor = Color.DarkGray;
                    return;
                }

                lbInvUsername.Visible = true;
                lbInvUsername.Text = "* Invalid username";
                tbPassword.ForeColor = Color.DarkGray;
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Password";
                return;
            }
        }
        private void btSignUp_Click(object sender, EventArgs e)
        {
            ucSIgnUp signup = new ucSIgnUp();
            signup.Dock = DockStyle.Fill;
            panel1.Controls.Add(signup);
            signup.BringToFront();
        }
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.ForeColor == Color.DarkGray)
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
                return;
            }
        }
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.DarkGray;
                return;
            }
        }
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.ForeColor == Color.DarkGray)
            {
                tbPassword.Text = "";
                tbPassword.PasswordChar = '*';
                tbPassword.ForeColor = Color.Black;
                return;
            }
        }
        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.PasswordChar = '\0';
                tbPassword.ForeColor = Color.DarkGray;
                return;
            }
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.ForeColor != Color.DarkGray)
            {
                if (cbShowPassword.Checked == true)
                {
                    tbPassword.PasswordChar = '\0';
                    return;
                }
                tbPassword.PasswordChar = '*';
            }
        }
    }
}
