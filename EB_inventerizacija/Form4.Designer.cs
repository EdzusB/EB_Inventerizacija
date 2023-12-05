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
            ((System.ComponentModel.ISupportInitialize)(this.izejviela_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // konekcija_button
            // 
            this.konekcija_button.Location = new System.Drawing.Point(359, 359);
            this.konekcija_button.Name = "konekcija_button";
            this.konekcija_button.Size = new System.Drawing.Size(75, 23);
            this.konekcija_button.TabIndex = 0;
            this.konekcija_button.Text = "Konekcija";
            this.konekcija_button.UseVisualStyleBackColor = true;
            this.konekcija_button.Click += new System.EventHandler(this.konekcija_button_Click);
            // 
            // izejviela_dgv
            // 
            this.izejviela_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izejviela_dgv.Location = new System.Drawing.Point(97, 47);
            this.izejviela_dgv.Name = "izejviela_dgv";
            this.izejviela_dgv.Size = new System.Drawing.Size(630, 278);
            this.izejviela_dgv.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izejviela_dgv);
            this.Controls.Add(this.konekcija_button);
            this.Name = "Form4";
            this.Text = "Izejvielu lietojums";
            ((System.ComponentModel.ISupportInitialize)(this.izejviela_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button konekcija_button;
        private System.Windows.Forms.DataGridView izejviela_dgv;
    }
}