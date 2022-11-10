using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyProject
{
    public static class SQLCommands
    {
        private static MySqlConnection conn;
        private static MySqlCommand cmd;
        private static void openConnection()
        {
            string dataSource = "datasource=localhost;username=root;password=;database=Spotify";
            try 
	        {
                conn = new MySqlConnection(dataSource);
                conn.Open();
	        }
	        catch (global::System.Exception)
	        {
                MessageBox.Show("Connection Fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }
        private static void closeConnection()
        {
            conn.Close();
        }
        public static void Create(string username, string email, string password)
        {
            openConnection();
            cmd = new MySqlCommand("INSERT INTO User (Username, Email, Password) VALUES (@Username, @Email, @Password)", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Created successfully! ", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            closeConnection();
        }
        public static MySqlDataReader Read()
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand("SELECT * FROM User", conn);
                return cmd.ExecuteReader();
            }
            finally
            {
                closeConnection();
            }      
        }
    }
}
