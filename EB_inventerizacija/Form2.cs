using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace EB_inventerizacija
{
    public partial class Form2 : Form
    {
        private List<string> GetListOfUsernamesFromDatabase()
        {
            List<string> usernameList = new List<string>();

            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=EB_inventerizacija.db; Version=3; New=True; Compress=True;"))
            {
                sqlite_conn.Open();

                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    sqlite_cmd.CommandText = "SELECT Lietotajvards FROM Darbinieks";

                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        while (sqlite_datareader.Read())
                        {
                            string username = sqlite_datareader["Lietotajvards"].ToString();
                            usernameList.Add(username);
                        }
                    }
                }
            }

            return usernameList;
        }

        private List<string> GetListOfHashedPasswordsFromDatabase()
        {
            List<string> hashedPasswordList = new List<string>();

            using (SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=EB_inventerizacija.db; Version=3; New=True; Compress=True;"))
            {
                sqlite_conn.Open();

                using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                {
                    sqlite_cmd.CommandText = "SELECT parole FROM Darbinieks";

                    using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                    {
                        while (sqlite_datareader.Read())
                        {
                            string password = sqlite_datareader["parole"].ToString();
                            hashedPasswordList.Add(password);
                        }
                    }
                }
            }

            return hashedPasswordList;
        }

        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Perform actions when the label is clicked
        }

        private void ieiet_button_Click(object sender, EventArgs e)
        {
            List<string> usernames = GetListOfUsernamesFromDatabase();
            List<string> hashedPasswords = GetListOfHashedPasswordsFromDatabase();

            string searchTextUsername = lietotajvards_Text.Text; // Get the text from your username TextBox
            string searchTextPassword = CalculateMD5Hash(parole_Text.Text); // Hash the password before comparing

            if (usernames.Contains(searchTextUsername) && hashedPasswords.Contains(searchTextPassword))
            {
            Form4 f4 = new Form4();
            f4.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!"); // Username or password not found in the database
                // Handle invalid login attempt
            }


        }
    }
}
