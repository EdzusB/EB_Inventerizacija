using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace EB_inventerizacija
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        static SQLiteConnection CreateConnection()
                {
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = new SQLiteConnection("Data Source=EB_inventerizacija.db; Version = 3; New = True; Compress = True; ");
                    try
                    {
                        sqlite_conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Konekcija neizdevās!");
                    }
                    return sqlite_conn;
                }
        private void registreties_Click(object sender, EventArgs e)
        {
            string input = Parole_Text.Text;
            string Parole = "";

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder parole = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    parole.Append(hashedBytes[i].ToString("x2")); // "x2" formats each byte as a two-digit hexadecimal number
                }
                Parole = parole.ToString();
            }

            registresana registresana1 = new registresana();
            registresana1.vards = Vards_Text.Text;
            registresana1.uzvards = Uzvards_Text.Text;
            registresana1.parole = Parole;
            registresana1.lietotajvards = Lietotajvards_Text.Text;

            if (Vards_Text.Text != "" && Uzvards_Text.Text != "" && Parole_Text.Text != "" && Lietotajvards_Text.Text != "")
            {
                try
                {
                    using (SQLiteConnection sqlite_conn = CreateConnection())
                    {
                        using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                        {
                            sqlite_cmd.CommandText = "INSERT INTO Darbinieks (Vards, Uzvards, Lietotajvards, Parole) VALUES ('" + registresana1.vards + "', '" + registresana1.uzvards + "', '" + registresana1.lietotajvards + "', '" + registresana1.parole + "');";
                            sqlite_cmd.ExecuteNonQuery();
                        }

                        Console.WriteLine("Data successfully inserted into the database.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ludzu aizpildiet visus ievades laukus!!!");
            }
            Form4 f4 = new Form4();
            f4.Show();
        }

        
    }

    class registresana
    {
        public string vards { get; set; }
        public string uzvards { get; set; }
        public string lietotajvards { get; set; }
        public string parole { get; set; }

        public void drukavardu()
        {
            Console.WriteLine("Darbinieks " + lietotajvards + " izveidots!");
        }
    }
}
