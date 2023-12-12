using System;
using System.Text;
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
        static SQLiteConnection CreateConnection() //Konekcija ar datubāzi
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
        private void registreties_Click(object sender, EventArgs e) //Funkcija, kas pievieno jaunu darbinieku
        {
            string input = Parole_Text.Text; //Iegūst tekstu no TextBox
            string Parole = ""; //Ievieš jaunu mainīgo

            using (MD5 md5 = MD5.Create()) //Šifrē paroli
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder parole = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    parole.Append(hashedBytes[i].ToString("x2"));
                }
                Parole = parole.ToString(); //Šifrētā parole
            }

            registresana registresana1 = new registresana(); //Jauns mainīgais
            registresana1.vards = Vards_Text.Text; //Mainīgajam piešķir vērtību
            registresana1.uzvards = Uzvards_Text.Text; //Mainīgajam piešķir vērtību
            registresana1.parole = Parole; //Mainīgajam piešķir vērtību
            registresana1.lietotajvards = Lietotajvards_Text.Text; //Mainīgajam piešķir vērtību

            if (Vards_Text.Text != "" && Uzvards_Text.Text != "" && Parole_Text.Text != "" && Lietotajvards_Text.Text != "") //Pārbauda vai neviens TextBox nav tukšs
            {
                try
                {
                    using (SQLiteConnection sqlite_conn = CreateConnection())
                    {
                        using (SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand())
                        {
                            sqlite_cmd.CommandText = "INSERT INTO Darbinieks (Vards, Uzvards, Lietotajvards, Parole) VALUES ('" + registresana1.vards + "', '" + registresana1.uzvards + "', '" + registresana1.lietotajvards + "', '" + registresana1.parole + "');"; //Ievada jauno darbinieku datubāzē
                            sqlite_cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ludzu aizpildiet visus ievades laukus!!!"); //Izvada paziņojumu, ja kāds lauks atstāts tukšs
            }
            Form4 f4 = new Form4(); //Ievieš jaunu mainīgo
            f4.Show(); //Pāriet uz Form4
        }

        
    }

    class registresana //Izveido klasi ar mainīgajiem
    {
        public string vards { get; set; }
        public string uzvards { get; set; }
        public string lietotajvards { get; set; }
        public string parole { get; set; }
    }
}
