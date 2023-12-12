using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

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
            sqlite_cmd.CommandText = "SELECT * From Izejviela";

            DataTable sTable = new DataTable();
            SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
            sqlda.Fill(sTable);
            izejviela_dgv.DataSource = sTable;
        }

        private void inventars_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventars_cbox.SelectedItem != null)
            {
                string selectedValue = inventars_cbox.SelectedItem.ToString();

                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Izejviela WHERE Nosaukums = @SelectedValue";
                sqlite_cmd.Parameters.AddWithValue("@SelectedValue", selectedValue);

                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    prece_dgv.DataSource = sTable;
                }
            }
            
        }

        private void saglabat_Click(object sender, EventArgs e)
        {
            int minDaudzums = 0;
            int maxDaudzums = 0;
            int pieejamaisDaudzums = 0;
            decimal cena = 0;
            int Skaits = 0;
            int atlikums = 0;
            decimal izmaksas = 0;
            int vajadzigs = 0;

            if (int.TryParse(skaits.Text, out int parsedSkaits))
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

                CreateConnection();
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Izejviela WHERE Nosaukums = @SelectedValue";
                sqlite_cmd.Parameters.AddWithValue("@SelectedValue", selectedValue);

                DataTable sTable;
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(sqlite_cmd);
                using (sTable = new DataTable())
                {
                    sqlda.Fill(sTable);
                    prece_dgv.DataSource = sTable;
                }

                if (sTable.Rows.Count > 0)
                {
                    minDaudzums = Convert.ToInt32(sTable.Rows[0]["min_daudzums"]);
                    maxDaudzums = Convert.ToInt32(sTable.Rows[0]["max_daudzums"]);
                    pieejamaisDaudzums = Convert.ToInt32(sTable.Rows[0]["pieejamais_daudzums"]);
                    cena = Convert.ToDecimal(sTable.Rows[0]["cena"]);

                }

                if (pieejamaisDaudzums - Skaits < 0)
                {
                    MessageBox.Show("Krājumos trūkst preču!");
                }

                atlikums = pieejamaisDaudzums - Skaits;

                if(atlikums <= minDaudzums)
                {
                    vajadzigs = maxDaudzums - atlikums;
                    izmaksas = vajadzigs * cena;

                    sqlite_cmd.CommandText = "UPDATE Izejviela SET pieejamais_daudzums = @NewPieejamais WHERE Nosaukums = @SelectedValue";
                    sqlite_cmd.Parameters.AddWithValue("@NewPieejamais", maxDaudzums);
                    sqlite_cmd.ExecuteNonQuery();
                }


            }
        }
    }
}



