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
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        private string dataSource = "datasource=localhost;username=root;password=;database=Spotify";

        public SignIn()
        {
            InitializeComponent();
            conn = new MySqlConnection(dataSource);
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("SELECT Username, Password FROM User", conn);

                conn.Open();

                dr = cmd.ExecuteReader();

                lbInvUsername.Visible = false;
                lbInvPassword.Visible = false;

                while (dr.Read())
                {
                    if (dr["Username"].ToString() == tbUsername.Text)
                    {
                        if (dr["Password"].ToString() == tbPassword.Text)
                        {
                            Spotify spotify = new Spotify();
                            spotify.Show();
                            this.Visible = false;
                            return;
                        }
                        lbInvPassword.Visible = true;
                        lbInvPassword.Text = "* Incorrect password";
                        tbPassword.PasswordChar = '\0';
                        tbPassword.Text = "Password";
                        tbPassword.ForeColor = Color.DarkGray;
                        return;
                    }
                }

                lbInvUsername.Visible = true;
                lbInvUsername.Text = "* Invalid username";
                tbUsername.ForeColor = Color.Red;

                tbPassword.ForeColor = Color.DarkGray;
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Password";
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Visible = false;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.ForeColor == Color.DarkGray)
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
                return;
            }
            
            if (tbUsername.ForeColor == Color.Red)
            {
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
            if (tbPassword.ForeColor == Color.DarkGray || tbPassword.ForeColor == Color.Red)
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
