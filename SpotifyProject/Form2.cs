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
    public partial class SignUp : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        private string dataSource ="datasource=localhost;username=root;password=;database=Spotify";

        public SignUp()
        {
            InitializeComponent();

            conn = new MySqlConnection(dataSource);
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (tbUsername.ForeColor == Color.DarkGray || tbEmail.ForeColor == Color.DarkGray || tbPassword.ForeColor == Color.DarkGray || tbConfPassword.ForeColor == Color.DarkGray)
            {
                MessageBox.Show("Fill in all fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lbInvUsername.Visible == true || lbInvEmail.Visible == true || lbInvPassword.Visible == true || lbConfPassword.Visible == true)
            {
                MessageBox.Show("Some field is incorrect", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                cmd = new MySqlCommand("INSERT INTO User (Username, Email, Password) VALUES (@Username, @Email, @Password)", conn);
     
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text);

                conn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("User Created successfully! ", "Congratulations",MessageBoxButtons.OK,MessageBoxIcon.Information);

                SignIn signIn = new SignIn();
                signIn.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
            finally
            {
                conn.Close();
            }
        }

        private void btCSignIn_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
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
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.DarkGray;
                lbInvUsername.Visible = false;
                return;
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.ForeColor == Color.DarkGray)
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
                return;
            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
                tbEmail.ForeColor = Color.DarkGray;
                lbInvEmail.Visible = false;
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
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.DarkGray;
                lbInvPassword.Visible = false;
                lbPasswordForce.Visible = false;
                return;
            }
        }

        private void tbConfPassword_Enter(object sender, EventArgs e)
        {
            if (tbConfPassword.ForeColor == Color.DarkGray)
            {
                tbConfPassword.Text = "";
                tbConfPassword.PasswordChar = '*';
                tbConfPassword.ForeColor = Color.Black;
                return;
            }
        }

        private void tbConfPassword_Leave(object sender, EventArgs e)
        {
            if (tbConfPassword.Text == "")
            {
                tbConfPassword.PasswordChar = '\0';
                tbConfPassword.Text = "Confirm Password";
                tbConfPassword.ForeColor = Color.DarkGray;
                lbConfPassword.Visible = false;
                return;
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lbInvUsername.Visible = false;

            if (tbUsername.Text.Length < 8)
            {
                lbInvUsername.Visible = true;
                lbInvUsername.Text = "* Very short username";
                return;
            }

            try
            {
                cmd = new MySqlCommand("SELECT Username FROM User", conn);

                conn.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Username"].ToString() == tbUsername.Text)
                    {
                        lbInvUsername.Visible = true;
                        lbInvUsername.Text = "* Username in use";
                        tbUsername.ForeColor = Color.Red;
                        return;
                    }
                    lbInvUsername.Visible = false;
                    tbUsername.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (Validations.EmailIsValid(tbEmail.Text) == false)
            {
                lbInvEmail.Visible = true;
                lbInvEmail.Text = "* Invalid email";
                return;
            }

            try
            {
                cmd = new MySqlCommand("SELECT Email FROM User", conn);

                conn.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Email"].ToString() == tbEmail.Text)
                    {
                        lbInvEmail.Visible = true;
                        lbInvEmail.Text = "* Email in use";
                        tbEmail.ForeColor = Color.Red;
                        return;
                    }
                    lbInvEmail.Visible = false;
                    tbEmail.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbConfPassword.Visible = false;
            lbInvPassword.Visible = false;
            lbPasswordForce.Visible = false;
            tbPassword.ForeColor = Color.Black;

            if (tbPassword.Text != tbConfPassword.Text && tbConfPassword.ForeColor != Color.DarkGray)
            {
                lbConfPassword.Visible = true;
                lbConfPassword.Text = "* Different password";
            }

            if (tbPassword.Text.Length < 8)
            {
                lbInvPassword.Visible = true;
                lbInvPassword.Text = "* Very short password";
                return;
            }

            if (Validations.StrongPassword(tbPassword.Text))
            {
                tbPassword.ForeColor = Color.Green;
                lbPasswordForce.Visible = true;
                lbPasswordForce.ForeColor = Color.Green;
                lbPasswordForce.Text = "Strong password";
                return;
            }
            else if (Validations.AveragePassword(tbPassword.Text))
            {
                tbPassword.ForeColor = Color.Orange;
                lbPasswordForce.Visible = true;
                lbPasswordForce.ForeColor = Color.Orange;
                lbPasswordForce.Text = "Avegare password";
                return;
            }
            else
            {
                tbPassword.ForeColor = Color.Red;
                lbPasswordForce.Visible = true;
                lbPasswordForce.ForeColor = Color.Red;
                lbPasswordForce.Text = "Weak password";
                return;
            }
        }

        private void tbConfPassword_TextChanged(object sender, EventArgs e)
        {
            lbConfPassword.Visible = false;
            tbConfPassword.ForeColor = Color.Black;

            if (tbConfPassword.Text != tbPassword.Text || tbPassword.ForeColor == Color.DarkGray)
            {
                lbConfPassword.Visible = true;
                lbConfPassword.Text = "* Different password";
                return;
            }

            else
            {
                if (tbPassword.ForeColor == Color.Green)
                {
                    tbConfPassword.ForeColor = Color.Green;
                    return;
                }
                if (tbPassword.ForeColor == Color.Orange)
                {
                    tbConfPassword.ForeColor = Color.Orange;
                    return;
                }
                if (tbPassword.ForeColor == Color.Red)
                {
                    tbConfPassword.ForeColor = Color.Red;
                    return;
                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.ForeColor != Color.DarkGray && tbConfPassword.ForeColor != Color.DarkGray)
            {
                if (cbShowPassword.Checked)
                {
                    tbPassword.PasswordChar = '\0';
                    tbConfPassword.PasswordChar = '\0';
                    return;
                }
                tbPassword.PasswordChar = '*';
                tbConfPassword.PasswordChar = '*';
            }
            else if (tbPassword.ForeColor != Color.DarkGray)
            {
                if (cbShowPassword.Checked)
                {
                    tbPassword.PasswordChar = '\0';
                    return;
                }
                tbPassword.PasswordChar = '*';
            }
            else if (tbConfPassword.ForeColor != Color.DarkGray)
            {
                if (cbShowPassword.Checked)
                {
                    tbConfPassword.PasswordChar = '\0';
                    return;
                }
                tbConfPassword.PasswordChar = '*';
            }
        }
    }
}
