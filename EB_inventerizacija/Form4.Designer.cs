namespace EB_inventerizacija
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.konekcija_button = new System.Windows.Forms.Button();
            this.izejviela_dgv = new System.Windows.Forms.DataGridView();
            this.inventars_cbox = new System.Windows.Forms.ComboBox();
            this.skaits = new System.Windows.Forms.TextBox();
            this.prece_dgv = new System.Windows.Forms.DataGridView();
            this.saglabat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.izejviela_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prece_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // konekcija_button
            // 
            this.konekcija_button.Location = new System.Drawing.Point(209, 313);
            this.konekcija_button.Name = "konekcija_button";
            this.konekcija_button.Size = new System.Drawing.Size(100, 33);
            this.konekcija_button.TabIndex = 0;
            this.konekcija_button.Text = "Konekcija";
            this.konekcija_button.UseVisualStyleBackColor = true;
            this.konekcija_button.Click += new System.EventHandler(this.konekcija_button_Click);
            // 
            // izejviela_dgv
            // 
            this.izejviela_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izejviela_dgv.Location = new System.Drawing.Point(12, 12);
            this.izejviela_dgv.Name = "izejviela_dgv";
            this.izejviela_dgv.Size = new System.Drawing.Size(470, 295);
            this.izejviela_dgv.TabIndex = 1;
            // 
            // inventars_cbox
            // 
            this.inventars_cbox.FormattingEnabled = true;
            this.inventars_cbox.Items.AddRange(new object[] {
            "Vīriešu T-krekls",
            "Vīriešu jaka",
            "Vīriešu džemperis",
            "Sieviešu jaka",
            "Sieviešu lietusmētelis",
            "Sieviešu T-krekls"});
            this.inventars_cbox.Location = new System.Drawing.Point(598, 12);
            this.inventars_cbox.Name = "inventars_cbox";
            this.inventars_cbox.Size = new System.Drawing.Size(121, 21);
            this.inventars_cbox.TabIndex = 2;
            this.inventars_cbox.SelectedIndexChanged += new System.EventHandler(this.inventars_cbox_SelectedIndexChanged);
            // 
            // skaits
            // 
            this.skaits.Location = new System.Drawing.Point(598, 195);
            this.skaits.Name = "skaits";
            this.skaits.Size = new System.Drawing.Size(100, 20);
            this.skaits.TabIndex = 3;
            // 
            // prece_dgv
            // 
            this.prece_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prece_dgv.Location = new System.Drawing.Point(532, 39);
            this.prece_dgv.Name = "prece_dgv";
            this.prece_dgv.Size = new System.Drawing.Size(240, 150);
            this.prece_dgv.TabIndex = 4;
            // 
            // saglabat
            // 
            this.saglabat.Location = new System.Drawing.Point(608, 221);
            this.saglabat.Name = "saglabat";
            this.saglabat.Size = new System.Drawing.Size(75, 23);
            this.saglabat.TabIndex = 5;
            this.saglabat.Text = "Saglabāt";
            this.saglabat.UseVisualStyleBackColor = true;
            this.saglabat.Click += new System.EventHandler(this.saglabat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saglabat);
            this.Controls.Add(this.prece_dgv);
            this.Controls.Add(this.skaits);
            this.Controls.Add(this.inventars_cbox);
            this.Controls.Add(this.izejviela_dgv);
            this.Controls.Add(this.konekcija_button);
            this.Name = "Form4";
            this.Text = "Izejvielu lietojums";
            ((System.ComponentModel.ISupportInitialize)(this.izejviela_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prece_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button konekcija_button;
        private System.Windows.Forms.DataGridView izejviela_dgv;
        private System.Windows.Forms.ComboBox inventars_cbox;
        private System.Windows.Forms.TextBox skaits;
        private System.Windows.Forms.DataGridView prece_dgv;
        private System.Windows.Forms.Button saglabat;
    }
}