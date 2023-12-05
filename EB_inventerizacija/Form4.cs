using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EB_inventerizacija
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=EB_inventerizacija.db; Version=3; New=True; Compress=True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("Failed to connect to the database.");
            }
            return sqlite_conn;
        }

        private async void konekcija_button_Click(object sender, EventArgs e)
        {
            await FetchAndUpdatePrices(); // Fetch data from the API and update the database

            // Load updated data from the database after modification
            using (SQLiteConnection sqlite_conn = CreateConnection())
            {
                sqlite_conn.Open();
                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Izejviela";

                DataTable sTable = new DataTable();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                sqlda.Fill(sTable);
                izejviela_dgv.DataSource = sTable;
            }
        }

        static async Task FetchAndUpdatePrices()
        {
            string apiUrl = "https://fakestoreapi.com/products";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<List<Cena>>(jsonData);

                    foreach (var product in products)
                    {
                        InsertProductIntoDatabase(product.cena);
                    }

                    MessageBox.Show("Prices updated in the database.");
                }
                else
                {
                    MessageBox.Show("Failed to fetch data from the API.");
                }
            }
        }

        static void InsertProductIntoDatabase(double price)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Izejviela (cena) VALUES (@Price)";
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.ExecuteNonQuery();
            }
        }
    }

    class Cena
    {
        public double cena { get; set; }
    }
}