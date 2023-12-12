using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Http;
using System.IO;

namespace EB_inventerizacija
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static SQLiteConnection CreateConnection() //Konekcija ar datubāzi
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=EB_inventerizacija.db; Version=3; New=True; Compress=True; ");
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

        private async void konekcija_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * From Prece"; //Ielasa visus datus no Tabulas Prece

            DataTable sTable = new DataTable();
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            sqlda.Fill(sTable);
            izejviela_dgv.DataSource = sTable; //Izvada visu uz ekrāna
        }

        private void inventars_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventars_cbox.SelectedItem != null) //Pārbauda, kuri datu jāielasa
            {
                string selectedValue = inventars_cbox.SelectedItem.ToString();

                CreateConnection(); //Izsauc funkciju
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Prece WHERE Nosaukums = @SelectedValue"; //Ielasa attiecīgos datus no datubāzes
                sqlite_cmd.Parameters.AddWithValue("@SelectedValue", selectedValue);

                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    prece_dgv.DataSource = sTable; //Parāda ielasītos datus
                }
            }
            
        }

        private async void saglabat_Click(object sender, EventArgs e)
        {
            int minDaudzums = 0; //Definē mainīgo
            int maxDaudzums = 0; //Definē mainīgo
            int pieejamaisDaudzums = 0; //Definē mainīgo
            int Skaits = 0; //Definē mainīgo
            int atlikums = 0; //Definē mainīgo
            int vajadzigs = 0; //Definē mainīgo

            if (int.TryParse(skaits.Text, out int parsedSkaits)) //TextBox tekstu pārvērš skaitlī
            {
                Skaits = parsedSkaits;
            }
            else
            {
                Skaits = 0;
            }

            if (inventars_cbox.SelectedItem != null)
            {
                string selectedValue = inventars_cbox.SelectedItem.ToString();

                CreateConnection(); //Izsauc funkciju
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Prece WHERE Nosaukums = @SelectedValue"; //Ielasa attiecīgos datus
                sqlite_cmd.Parameters.AddWithValue("@SelectedValue", selectedValue);

                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    prece_dgv.DataSource = sTable; //Izvada ielasītos datus
                }

                if (sTable.Rows.Count > 0)
                {
                    minDaudzums = Convert.ToInt32(sTable.Rows[0]["min_daudzums"]); //Piešķir mainīgajam vērtību no ielasītajiem datiem
                    maxDaudzums = Convert.ToInt32(sTable.Rows[0]["max_daudzums"]); //Piešķir mainīgajam vērtību no ielasītajiem datiem
                    pieejamaisDaudzums = Convert.ToInt32(sTable.Rows[0]["pieejamais_daudzums"]); //Piešķir mainīgajam vērtību no ielasītajiem datiem
                }

                if (pieejamaisDaudzums - Skaits < 0) //Pārbauda vai noliktavā ir pietiekami daudz preču
                {
                    MessageBox.Show("Noliktavā trūkst preču!");
                }

                atlikums = pieejamaisDaudzums - Skaits; //Aprēķina cik preču palicis

                if (atlikums <= minDaudzums) //Pārbauda vai nevajag papildināt preču krājumus
                {
                    vajadzigs = maxDaudzums - atlikums; //Aprēķina cik preču nepieciešams

                    sqlite_cmd.CommandText = "UPDATE Prece SET pieejamais_daudzums = @NewPieejamais WHERE Nosaukums = @SelectedValue"; //Atjauno datubāzes datus
                    sqlite_cmd.Parameters.AddWithValue("@NewPieejamais", maxDaudzums); //Atjauno datubāzes datus
                    sqlite_cmd.ExecuteNonQuery();
                }
                else
                {
                     sqlite_cmd.CommandText = "UPDATE Prece SET pieejamais_daudzums = @NewPieejamais WHERE Nosaukums = @SelectedValue"; //Atjauno datubāzes datus
                     sqlite_cmd.Parameters.AddWithValue("@NewPieejamais", atlikums); //Atjauno datubāzes datus
                    sqlite_cmd.ExecuteNonQuery();
                }
                konekcija(); //Izsauc unkciju
                string apiUrl = "http://worldtimeapi.org/api/ip"; //Deinē mainīgo

                string filePath = $"Ceks_{DateTime.Now:yyyyMMdd_HHmmss}.txt"; //Definē un piešķir mainīgajam vērtību
                using (StreamWriter writer = File.CreateText(filePath)) //Izveido jaunu teksta failu
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            HttpResponseMessage response = await client.GetAsync(apiUrl);
                            if (response.IsSuccessStatusCode)
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();

                                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(apiResponse);
                                string currentDateTime = data.datetime;

                                writer.WriteLine("Laiks, kurā veikts ieraksts:" + currentDateTime); //Ieraksta failā
                                writer.WriteLine("Preces nosaukums: " + selectedValue); //Ieraksta failā
                                writer.WriteLine("Pārdoto preču skaits: " + Skaits); //Ieraksta failā
                                writer.WriteLine("Atlikušo preču skaits: " + atlikums); //Ieraksta failā
                                writer.WriteLine("Papildināto preču skaits: " + vajadzigs); //Ieraksta failā
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Kļūda faila izveidē: " + ex.Message); //Izvada paziņojumu, ja aila izveide nav izdevusies
                    }
                }
            }
        }
        public void konekcija() //Funkcija, kas izvada datus no datubāzes
        {
            SQLiteConnection sqlite_conn = CreateConnection();

            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * From Prece"; //Atlasa attiecīgos datus

            DataTable sTable = new DataTable();
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            sqlda.Fill(sTable);
            izejviela_dgv.DataSource = sTable; //Izvada datus attiecīgajā laukā
        }
    }
}



