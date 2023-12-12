using System;
using System.Windows.Forms;

namespace EB_inventerizacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pierakstisanas_button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); //ievieš jaunu mainīgo
            f2.Show(); //pāriet uz form2
        }

        private void registresanas_button_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); //ievieš jaunu mainīgo
            f3.Show(); //pāriet uz form3
        }
    }
}
